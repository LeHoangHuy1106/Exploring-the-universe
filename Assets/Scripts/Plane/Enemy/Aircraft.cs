using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : Enemy
{

    public float amplitude = 1f; // Biên độ
    public float frequency = 1f; // Tần số

    void Start()
    {
        StartCoroutine(startShoot());
    }

    public override void Moving()
    {
        float x = amplitude * Mathf.Sin(frequency * Time.time);
        float z = GetSpeed();

        rb.velocity = new Vector3(x, 0, z);

        
    }
        
    // Update is called once per frame
    void Update() 
    {
        Moving();
        Limit();
       
    }

    IEnumerator startShoot()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        shoot();
        StartCoroutine(startShoot());
    }

    protected override void shoot()
    {
        base.shoot();
        GameObject bullet = GetObjectPool().GetObject("AircraftBullet");
        bullet.transform.localPosition = transform.localPosition;
        bullet.active = true;

    
    }

}
