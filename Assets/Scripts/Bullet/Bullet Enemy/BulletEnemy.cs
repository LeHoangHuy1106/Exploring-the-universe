using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour, IBullet
{
    [SerializeField]
    private float speed;

    [SerializeField]
    protected Rigidbody rb;

    [SerializeField]
    ObjectPool objectPool;

    public float GetSpeed()
    {
        return this.speed;

    }

    public void Limit()
    {
        Vector3 postion;
        postion = transform.localPosition;

        if (postion.x <= -24f || postion.x > 24f)
        {
            gameObject.active = false;
        }
        else if (postion.z <= -28f || postion.z >= 2f)
        {
            gameObject.active = false;
        }
    }

    public void Moving()
    {
        rb.velocity = (Vector3.back) * this.speed;

    }

    public void rotation()
    {
       
    }

    public void setPosition(Vector3 pos) { 
   
    }

    public void SetSpeed(float speed)
    {
       
    }

    public void collide(Collision collision, string tag)
    {
       
    }

    public ObjectPool GetObjectPool()
    {
        return objectPool;
    }
}
