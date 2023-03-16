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


                OnClickShooter(0);

            }
            if (Input.GetKeyDown(KeyCode.X))
            {

                OnClickShooter(1);

               

            }
            if (Input.GetKeyDown(KeyCode.C))
            {

                OnClickShooter(2);

            }




        }
    }

    public void OnClickShooter(int i)
    {
        ChooseBullet(i);
        limit = Time.time + time;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Collision(collision);
    }



}