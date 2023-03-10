using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraftBullet : BulletEnemy
{

    // Update is called once per frame
    void Update()
    {
        Moving();
        Limit();
    }
}
