using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBullets : BulletPlayer
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetSpeed(20f);
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Limit();
    }
}
