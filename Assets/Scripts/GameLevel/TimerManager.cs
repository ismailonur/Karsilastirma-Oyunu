using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Text sureTxt;

    int kalanSure;
    bool sureKontrol;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        kalanSure = 10;
        sureKontrol = true; 
    }

    public void SureyiBaslat()
    {
        StartCoroutine(SureTimerRoutine());
    }

    IEnumerator SureTimerRoutine()
    {
        while (sureKontrol)
        {
            yield return new WaitForSeconds(1f);

            if(kalanSure < 10)
            {
                sureTxt.text = "0" + kalanSure.ToString();
            }
            else
            {
                sureTxt.text = kalanSure.ToString();
            }

            if(kalanSure <= 0)
            {
                sureKontrol = false;
                sureTxt.text = "00";

                gameManager.OyunuBitir();
            }

            kalanSure--;
        }
    }
}
