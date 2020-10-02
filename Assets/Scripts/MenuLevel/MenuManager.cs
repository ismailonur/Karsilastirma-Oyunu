using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    public Transform kafa;
    public Transform startButon;

    void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveY(150f, 1f).SetEase(Ease.OutBack);
        startButon.transform.GetComponent<RectTransform>().DOLocalMoveY(-200f, 1f).SetEase(Ease.OutBack);
    }


    void Update()
    {
        
    }

    public void OyunaBasla()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
