using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GeriSayimManager : MonoBehaviour
{
    public GameObject geriSayim;
    public Text geriSayimText;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        //StartCoroutine(GeriyeSayRoutine());
    }

    IEnumerator GeriyeSayRoutine()
    {
        geriSayimText.text = "3";
        yield return new WaitForSeconds(.5f);

        geriSayim.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.5f);
        geriSayim.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(.5f);

        geriSayimText.text = "2";
        yield return new WaitForSeconds(.5f);

        geriSayim.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.5f);
        geriSayim.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(.5f);

        geriSayimText.text = "1";
        yield return new WaitForSeconds(.5f);

        geriSayim.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.5f);
        geriSayim.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(.5f);

        StopAllCoroutines();

        gameManager.OyunaBasla();
    }
}
