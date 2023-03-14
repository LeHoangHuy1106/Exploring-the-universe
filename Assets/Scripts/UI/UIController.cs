using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject panelStore;


    public void isPanelStore()
    {
        panelStore.SetActive(!panelStore.active);
    }
}
