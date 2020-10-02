using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public GameObject ustPanel;
    public GameObject altYazi;
    public GameObject ustDikdortgen;
    public GameObject altDikdortgen;

    void Start()
    {
        SahnedekileriGetir();
    }

    void SahnedekileriGetir()
    {
        ustPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altYazi.GetComponent<CanvasGroup>().DOFade(1, 1f);

        ustDikdortgen.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        altDikdortgen.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
    }

    public void OyunaBasla()
    {
        Debug.Log("Başladı");
    }
}
