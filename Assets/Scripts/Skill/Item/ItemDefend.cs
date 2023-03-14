using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDefend : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="E1")
        {
            other.gameObject.SetActive(false);
            GameObject boom = ObjectPool.Instance.GetObject("Boom1");
            boom.transform.position = transform.position;
            boom.SetActive(true);

        }
        if (other.tag == "E2")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            GameObject boom = ObjectPool.Instance.GetObject("Boom2");
            boom.transform.position = transform.position;
            boom.SetActive(true);

        }
    }
}
