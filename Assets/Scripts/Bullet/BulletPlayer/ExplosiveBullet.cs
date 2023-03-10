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
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed(10);
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Limit();
    }
}
