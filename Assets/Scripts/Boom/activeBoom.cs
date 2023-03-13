using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeBoom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float timeToDisable = 2.0f;

    void OnEnable()
    {
        
        StartCoroutine(DisableAfterTime());
    }

    IEnumerator DisableAfterTime()
    {

        yield return new WaitForSeconds(timeToDisable);
        gameObject.SetActive(false);

    }

}
