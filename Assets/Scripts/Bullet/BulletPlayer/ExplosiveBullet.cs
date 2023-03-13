using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBullet : BulletPlayer
{
    public float amplitude = 10f; // Biên độ
    public float frequency = 5f; // Tần số
    public override void Moving()
    {
        float x = amplitude * Mathf.Sin(frequency * Time.time);
        float z = GetSpeed();
        rb.velocity = new Vector3(x, 0, z);

    }
    private void OnEnable()
    {
       
        SetSpeed(10);
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Moving();
        Limit();
    }
    private void OnCollisionEnter(Collision collision)
    {
        collide(collision, "E1");
    }

    private void OnDisable()
    {
        GameObject boomYellow = GetObjectPool().GetObject("YellowBoom");
        boomYellow.transform.localPosition = transform.localPosition;
        boomYellow.SetActive(true);
    }

}
