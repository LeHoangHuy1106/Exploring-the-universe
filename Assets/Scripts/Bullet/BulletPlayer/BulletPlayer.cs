using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour, IBullet
{
    [SerializeField]
    protected Rigidbody rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    ObjectPool objectPool;

    



    Vector3 postion;



    public void collide(Collision  collision, string tag)
    {

        if (collision.gameObject.CompareTag(tag))
        {
            
            
            GameObject  boom =   GetObjectPool().GetObject("Boom1");
            boom.transform.localPosition = transform.localPosition;
            boom.SetActive(true);
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);


        }

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
        postion = transform.localPosition;

        if (postion.x <= -24f || postion.x > 24f)
        {
            gameObject.SetActive(false);
        }
        else if (postion.z <= -28f || postion.z >= -2f)
        {
            gameObject.SetActive(false);
        }

    }

    public virtual void Moving()
    {
        rb.velocity = (Vector3.forward * GetSpeed());

    }

    public virtual void rotation()
    {

    }

    public void setPosition(Vector3 pos)
    {

    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }


}
