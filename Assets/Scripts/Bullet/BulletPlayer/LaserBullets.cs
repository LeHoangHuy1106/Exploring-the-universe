using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullets : BulletPlayer
{


    private void Start()
    {
    }
    private void Update()
    {
        Moving();
        Limit();
    }


    private void OnCollisionEnter(Collision collision)
    {
        collide(collision, "E1");
    }


}
