using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitPanelToCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] RectTransform panelRectTransform, canvasRectTransform, panelPoint, eviromentRectTransform, background; 

    void Start()
    {

        panelRectTransform.sizeDelta = canvasRectTransform.sizeDelta;
        background.sizeDelta = eviromentRectTransform.sizeDelta *1.2f;

        Vector2 currentSize = canvasRectTransform.sizeDelta;
        currentSize.y = currentSize.y /8;
        panelPoint.sizeDelta = currentSize;


    }
}
