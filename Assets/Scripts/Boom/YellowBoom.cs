using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBoom : MonoBehaviour
{
    [SerializeField]
    ObjectPool objectPool;

    GameObject boom;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="E1")
        {
            StartCoroutine(DisableAfterTime( other));
        }
    }
    IEnumerator DisableAfterTime( Collider other)
    {

        yield return new WaitForSeconds(1f);
        other.gameObject.SetActive( false);
        Debug.Log("co va  cham");
        boom = objectPool.GetObject("Boom1");
        boom.transform.localPosition = other.transform.localPosition;
        boom.SetActive(true);
    }

}
