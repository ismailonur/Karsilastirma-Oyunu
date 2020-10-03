using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DairelerManager : MonoBehaviour
{
    public GameObject[] dairelerDizi;

    void Start()
    {
        DairelerScaleKapat();
    }

    void DairelerScaleKapat()
    {
        foreach(GameObject daire in dairelerDizi)
        {
            daire.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }
    
    public void DaireninScaleAc(int hangiDaire)
    {
        dairelerDizi[hangiDaire].GetComponent<RectTransform>().DOScale(1, .3f);

        if(hangiDaire % 5 == 0)
        {
            DairelerScaleKapat();
        }
    }
}
