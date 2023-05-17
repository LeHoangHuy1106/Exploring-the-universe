using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlowTime : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0.4f;
    }
    private void OnDisable()
    {
        Time.timeScale = 1f;
    }
    private void Update()
    {
        Debug.Log(Time.time);
    }

}
