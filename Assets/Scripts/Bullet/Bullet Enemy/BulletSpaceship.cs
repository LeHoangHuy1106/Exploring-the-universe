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
      
     //   Limit();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "P1" || other.tag == "E1")
        {

            if( count<=2)
            {
                count++;
                other.gameObject.SetActive(false);
                GameObject boom = ObjectPool.Instance.GetObject("Boom1");
                boom.transform.localPosition = other.gameObject.transform.localPosition;
                boom.SetActive(true);
            }
            else
            {
                GameObject boom = ObjectPool.Instance.GetObject("Boom2");

                boom.transform.localPosition = other.gameObject.transform.localPosition;
                boom.SetActive(true);
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
                ScoreCotroller.GetInstance().SetScore("point", 1);
            }



        }
        if (other.tag == "P2")
        {
            GameObject boom = ObjectPool.Instance.GetObject("Boom2");
            boom.transform.localPosition = other.gameObject.transform.localPosition;
            boom.SetActive(true);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            ScoreCotroller.GetInstance().SetScore("point", 1);
        }
        if (other.tag == "Player")
        {
            GameObject boom = ObjectPool.Instance.GetObject("Boom2");
            boom.transform.localPosition = other.gameObject.transform.localPosition;
            boom.SetActive(true);
            ScoreCotroller.GetInstance().SetScore("hp", -1);
        }

    }
}
