using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitController : MonoBehaviour
{


    [SerializeField]
    GameObject right, left, botton, top;

    private void Start()
    {
        SetPos();
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
    void SetPos()
    {
        float ratio = (float)Screen.width / (float)Screen.height;
        Debug.Log(ratio);
        Vector3 T = right.transform.position;
        T.x = 15f * ratio+6f;
        right.transform.position = T;
        T.x = -15f * ratio - 6f;
        left.transform.position = T;

    }
        
}
