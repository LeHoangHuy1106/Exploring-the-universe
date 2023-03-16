using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Enemy
{
    float speedR,x,y,z;


    private void OnEnable()
    {
        Moving();
        setLevel(1);
        SetSpeed(Random.Range(700f, 2000f));

    }
    private void Start()
    {

     
        
    }
    
    private void Update()
    {
        rotate();
        
    //    Limit();
    }
    void rotate()
    {
        speedR = Random.Range(3, 4);
        x = Random.Range(0, 180);
        y = Random.Range(0, 180);
        z = Random.Range(0, 180);

        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime * speedR);
    }

    public override void Shoot()
    {
       
    }
}
