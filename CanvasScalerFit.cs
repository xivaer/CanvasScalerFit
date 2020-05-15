using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerFit : MonoBehaviour
{
    [SerializeField]
    private CanvasScaler _canvas;

    public float baseWidth = 1024;
    public float baseHeight = 768;
    public float baseOrthographicSize = 1;

    private void Awake()
    {
        float baseMatchWidthOrHeight = (float)baseHeight / (float)baseWidth;
        float newMatchWidthOrHeight = (float)Screen.height / (float)Screen.width;
        if (newMatchWidthOrHeight > baseMatchWidthOrHeight)
            _canvas.matchWidthOrHeight = 0.855f;
    }

}
