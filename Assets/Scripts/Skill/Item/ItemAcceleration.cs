using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAcceleration : MonoBehaviour
{
    [SerializeField]
    Myplane myplane;
    private void OnEnable()
    {
        Time.timeScale = 0.4f;
        myplane.SetSpeed(myplane.GetSpeed() * 2);

    }
    private void OnDisable()
    {
        myplane.SetSpeed(myplane.GetSpeed() / 2);
    }
}
