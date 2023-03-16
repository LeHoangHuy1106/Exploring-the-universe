using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullets : BulletPlayer
{


    private void OnEnable()
    {
    //    ScoreCotroller.GetInstance().SetScore("red", -1);
    }
    private void Update()
    {
        Moving();
        Limit();
        if (315 == Mathf.Abs(transform.rotation.eulerAngles.y) )
        {

            rb.velocity = new Vector3(-1, 0, 1) * GetSpeed();
        }
        else if (45 == Mathf.Abs(transform.rotation.eulerAngles.y))
        {
          
            rb.velocity = new Vector3(1, 0, 1) * GetSpeed();

        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        collide(collision, "E1");

    }

    private void OnDisable()
    {
        transform.eulerAngles = new Vector3(90f, 0f, 0f);
    }

}
