using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaceship : BulletEnemy
{
    [SerializeField]
    Transform player;
    int count;


    private void OnEnable()
    {
        count = 0;
        SetSpeed(20);
        if (player)
        {
            
            Vector3 direction = player.localPosition - transform.localPosition;
            Vector3 velocity = direction.normalized * GetSpeed();
            rb.velocity = velocity;
            transform.LookAt(player);
        }
    }

    void Update()
    {
        Debug.Log(rb.velocity);
        Limit();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "P1" || other.tag == "E1")
        {

            if( count<=2)
            {
                count++;
                other.gameObject.SetActive(false);
                GameObject boom = GetObjectPool().GetObject("Boom1");
                boom.transform.localPosition = other.gameObject.transform.localPosition;
                boom.SetActive(true);
            }
            else
            {
                GameObject boom = GetObjectPool().GetObject("Boom2");
                boom.transform.localPosition = other.gameObject.transform.localPosition;
                boom.SetActive(true);
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }


        }
        if (other.tag == "P2")
        {
            GameObject boom = GetObjectPool().GetObject("Boom2");
            boom.transform.localPosition = other.gameObject.transform.localPosition;
            boom.SetActive(true);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
