﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrueFalseManager : MonoBehaviour
{
    public GameObject trueIcon, falseIcon;

    void Start()
    {
        ScaleKapat();
    }

    public void TrueFalseScaleAc(bool dogrumu)
    {
        if (dogrumu)
        {
            trueIcon.GetComponent<RectTransform>().DOScale(1, .2f);
            falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
        else
        {
            falseIcon.GetComponent<RectTransform>().DOScale(1, .2f);
            trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        Invoke("ScaleKapat", .5f);
    }

    void ScaleKapat()
    {
        trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
