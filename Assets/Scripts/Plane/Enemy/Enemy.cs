using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IPlane
{
    [SerializeField]
    ObjectPool objectPool;
    [SerializeField]
    Transform Enemypostion;
    [SerializeField]
    protected  Rigidbody rb;
    [SerializeField]
    float speed;

    int level;
    public void Conllider()
    {
       
    }

    public ObjectPool GetObjectPool()
    {
        return this.objectPool;
    }

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
            gameObject.SetActive(false);
        }
    }

    public virtual void Moving()
    {
        rb.velocity = (Vector3.back) * GetSpeed() * Time.deltaTime;
    }

    public void SetObjectPool(ObjectPool objectPool)
    {
        
    }

    public void SetPositon(Vector3 pos)
    {
      
        
        Enemypostion.localPosition = pos;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void setLevel(int level)
    {
        this.level = level;
    }

    public int getLevel()
    {
        return this.level;
    }

    protected virtual void shoot() { }
}
