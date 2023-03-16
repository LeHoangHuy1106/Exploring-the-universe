using UnityEngine;
using UnityEngine.UI;
public class ScaleCanvas : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
  
    public RectTransform canvasRectTransform;


    private void Awake()
    {
        SetCanvasSize();
    }

    private void SetCanvasSize()
    {
        float referenceWidth = 1080f; // reference width of your UI design
        float referenceHeight = 1920f; // reference height of your UI design

        float deviceWidth = Screen.width;
        float deviceHeight = Screen.height;
        float deviceAspectRatio = deviceWidth / deviceHeight;

        float canvasScale = 0f;

        if (deviceAspectRatio <= (referenceWidth / referenceHeight))
        {
            canvasScale = deviceWidth / referenceWidth;
        }
        else
        {
            canvasScale = deviceHeight / referenceHeight;
        }

        canvasRectTransform.localScale = new Vector3(canvasScale, canvasScale, 1f);
    }
}