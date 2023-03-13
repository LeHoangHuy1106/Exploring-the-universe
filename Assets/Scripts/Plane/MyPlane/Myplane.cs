using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Myplane : MonoBehaviour, IPlane
{

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private Transform planePosition;

    [SerializeField]
    private ObjectPool ObjectPool;

    [SerializeField]
    private JoyStick joyStick;

    private float speed;

    

    public void Collision(Collision collision)
    {
         if ( collision.gameObject.CompareTag("PHP"))
        {
            collision.gameObject.SetActive ( false);
        }
        else if (collision.gameObject.CompareTag("PRed"))
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("PBlue"))
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("PYellow"))
        {
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("E1"))
        {
            collision.gameObject.SetActive(false);
            GameObject boom = GetObjectPool().GetObject("Boom1");
            boom.transform.localPosition = transform.localPosition;
            boom.SetActive(true);
        }
    }

    public float GetSpeed()
    {
        return this.speed;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void Limit()
    {
        Vector3 T = transform.localPosition;
        T.x = Mathf.Clamp(T.x, -23.0f, 23.0f);
        T.z = Mathf.Clamp(T.z, -27f, -3f);
        transform.localPosition = T;
    }

    public void Moving()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -4f);

    }

    public void MovingByJoystick()
    {

        float moveHorizontal = joyStick.Horizontal();
        float moveVertical = joyStick.Vertical();
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -4f);
    }

    public void SetPositon(Vector3 pos)
    {
        planePosition.localPosition = pos;
    }

    protected abstract void Shoot();



    public ObjectPool GetObjectPool()
    {
       return  this.ObjectPool;
    }

    public void SetObjectPool(ObjectPool objectPool)
    {
        this.ObjectPool = objectPool;
    }

   


    GameObject bullet;
    protected void ShootLaserBullet( Vector3 pos)
    {
        bullet = GetObjectPool().GetObject("LaserBullet");
        bullet.transform.position = pos;
        bullet.SetActive(true);
        
    }
    protected void ShootThrowingBullet(Vector3 pos)
    {
        bullet = GetObjectPool().GetObject("ThrowingBullet");
        bullet.transform.position = pos;
        bullet.SetActive(true);

    }
    
    protected void ShootExplosiveBullet(Vector3 pos)
    {
        bullet = GetObjectPool().GetObject("ExplosiveBullet");
        bullet.transform.position = pos;
        bullet.SetActive(true);
       
    }

}
