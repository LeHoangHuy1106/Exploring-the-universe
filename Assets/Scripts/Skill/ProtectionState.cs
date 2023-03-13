using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProtectionState : IState
{
    bool active;
    [SerializeField] GameObject item;


    public bool Active { get; set; }
    


    public GameObject GetItem()
    {
        return this.item;
    }

    public void Action()
    {
        item.SetActive(active);
     }

}
