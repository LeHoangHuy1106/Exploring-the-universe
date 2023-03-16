using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlowTime : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0.6f;
    }
    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

}
