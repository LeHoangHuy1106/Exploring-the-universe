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

    public override void Shoot()
    {
        if (Time.time >= limit)
        {
           
            if (Input.GetKeyDown(KeyCode.Z))
            {

                ChooseBullet(0);

                limit = Time.time + time;
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                ChooseBullet(1);
                limit = Time.time + time;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                ChooseBullet(2);
                limit = Time.time + time;
            }

        }
        
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        Collision(collision);
    }


}
