
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class JoyStick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField]
    private Image joystickBackground;

    [SerializeField]
    private Image joystickHandle;

    [SerializeField]
    private Vector3 inputVector;


    private void Start()
    {
    //    joystickBackground.enabled = false;
      //  joystickHandle.enabled = false;
    }


    //Press down on the screen
    public virtual void OnPointerDown(PointerEventData ped)
    {
        joystickBackground.enabled = true;
        joystickHandle.enabled = true;
        Debug.Log("Nhấn xuống");

        OnDrag(ped);
    }
    //Press up  on the screen
    public virtual void OnPointerUp(PointerEventData ped)
    {
        Debug.Log("Nhấn lên");
      //  joystickBackground.enabled = false;
      //  joystickHandle.enabled = false;
        inputVector = Vector3.zero;
        joystickHandle.rectTransform.anchoredPosition = Vector3.zero;
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBackground.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joystickBackground.rectTransform.sizeDelta.x);
            pos.y = (pos.y / joystickBackground.rectTransform.sizeDelta.y);

            float x = (joystickBackground.rectTransform.pivot.x == 1f) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (joystickBackground.rectTransform.pivot.y == 1f) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            inputVector = new Vector3(x, 0, y);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            joystickHandle.rectTransform.anchoredPosition = new Vector3(inputVector.x * (joystickBackground.rectTransform.sizeDelta.x / 3), inputVector.z * (joystickBackground.rectTransform.sizeDelta.y / 3));
        }
    }

    public float Horizontal()
    {
        if (inputVector.x != 0)
            return inputVector.x;
        else
            return Input.GetAxis("Horizontal");
    }

    public float Vertical()
    {
        if (inputVector.z != 0)
            return inputVector.z;
        else
            return Input.GetAxis("Vertical");
    }



}
