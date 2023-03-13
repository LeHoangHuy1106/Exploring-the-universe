using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetAirplane : Myplane
{
    [SerializeField]
    private float limit;
    float time = 0.2f;

    private void Start()
    {
        SetSpeed(10f);
        SetPositon(new Vector3(0f, 30f, -25f));
    }
    private void Update()
    {
        //Moving();
        MovingByJoystick();
        Limit();
        Shoot();
    }

    protected override void Shoot()
    {
        if (Time.time >= limit)
        {
           
            if (Input.GetKeyDown(KeyCode.Z))
            {
                ShootLaserBullet(transform.localPosition);

                limit = Time.time + time;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Vector3 temp = transform.localPosition;
                temp.z += 1.9f;
                ShootThrowingBullet(temp);
                limit = Time.time + time;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                Vector3 temp = transform.localPosition;
                temp.z += 1.5f;
                ShootExplosiveBullet(temp);
                limit = Time.time + time;
            }

        }
        
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        Collision(collision);
    }


}
