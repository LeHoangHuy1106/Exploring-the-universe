using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IState
{
   
    bool Active { get; set; }
    void Action();
    GameObject GetItem();


}
