using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleship : Enemy
// Start is called before the first frame update
    
{
    [SerializeField]
    Transform player, ship;
    bool isBan;
    int count;

    private void OnEnable()
    {
        SetSpeed(100f);
        Moving();
        StartCoroutine(startShoot());
        isBan = false;
        count = 0;
    }


    private void Update()
    {
        if (transform.localPosition.z <= -5f)
        {
            isBan = true;
            rb.velocity = Vector3.zero;
            ship.transform.LookAt(player);
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

    }
    IEnumerator startShoot()
    {
    
        yield return new WaitForSeconds(Random.Range(0.5f, 3f));
        if (isBan)
        {
            shoot();
        }
        StartCoroutine(startShoot());
    }

    protected override void shoot()
    {

        GameObject bullet = GetObjectPool().GetObject("SpaceshipBullet");
        Vector3 temp = transform.localPosition;
     
        bullet.transform.localPosition = temp;
        bullet.SetActive(true);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" || other.tag == "P2")
        {
            if(other.tag == "P1")
            {
                count++;
            }
            if (other.tag =="P2")
            {
                count += 2;
            }
            if (count <= 9)
            {
               
                other.gameObject.SetActive(false);
                GameObject boom = GetObjectPool().GetObject("Boom2");
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
    }

}
