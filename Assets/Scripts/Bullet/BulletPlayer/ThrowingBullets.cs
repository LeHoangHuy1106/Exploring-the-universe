using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBullets : BulletPlayer
{
    private int count;
    // Start is called before the first frame update

    private void OnEnable()
    {
        Moving();
        
        count = 0;
    }

    private void Start()
    {
        SetSpeed(30f);
    }

    // Update is called once per frame
    void Update()
    {
        
        Limit();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("E1"))
        {
            count++;
            if(count <=2)
            {
                collision.gameObject.SetActive(false);

            }
            else
            {
                collision.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
            GameObject boom = ObjectPool.Instance.GetObject("Boom1");
            boom.transform.localPosition = transform.localPosition;
            boom.SetActive(true);
        }
    }

    
}
