using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonucManager : MonoBehaviour
{
    public Text dogruAdetTxt, yanlisAdetTxt, puanTxt;

    public void SonuclariGoster(int dogruAdet, int yanlisAdet, int puan)
    {
        dogruAdetTxt.text = dogruAdet.ToString();
        yanlisAdetTxt.text = yanlisAdet.ToString();
        puanTxt.text = puan.ToString();
    }
}
