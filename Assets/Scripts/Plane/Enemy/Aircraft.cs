using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : Enemy
{
  
    public float amplitude = 1f; // Biên độ
    public float frequency = 1f; // Tần số

    private void OnEnable()
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
        Debug.Log("co");
        yield return new WaitForSeconds(Random.Range(0.5f, 3f));
        Shoot();
        StartCoroutine(startShoot());
    }

    public  override void Shoot()
    {
      
        GameObject bullet =  ObjectPool.Instance.GetObject("AircraftBullet");
        Vector3 temp = transform.localPosition;
        temp.z -= 1f;
        bullet.transform.localPosition = temp ;
        bullet.SetActive(true);

    
    }

}
