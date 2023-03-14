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
    private JoyStick joyStick;

    private float speed;

    BulletFactory bulletFactory = new BulletFactory();
    GameObject bullet;


    public void Collision(Collision collision)
    {
        if (collision.gameObject.CompareTag("PHP"))
        {
            collision.gameObject.SetActive(false);
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
            GameObject boom = ObjectPool.Instance.GetObject("Boom1");
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

    private float screenWidth;
    private float screenHeight;

    private float objectWidth;
    private float objectHeight;
    private Camera mainCamera;
    public void Limit()
    {
        float minX, maxX, minY, maxY;
        Vector3 T = transform.localPosition;
        T.x = Mathf.Clamp(T.x, -23.0f, 23.0f);
        T.z = Mathf.Clamp(T.z, -27f, -3f);
        transform.localPosition = T;
        
        /*
        mainCamera = Camera.main;

        screenHeight = mainCamera.orthographicSize * 2f;
        screenWidth = screenHeight * mainCamera.aspect;

        objectHeight = transform.localScale.z;
        objectWidth = transform.localScale.x;
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        float xMin = objectWidth / 2f;
        float xMax = screenWidth - objectWidth / 2f;

        float zMin = objectHeight / 2f;
        float zMax = screenHeight - objectHeight / 2f;

        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0.0f, 1.0f);
        viewportPosition.y = Mathf.Clamp(viewportPosition.y, 0.0f, 1.0f);
        viewportPosition.z = Mathf.Clamp(viewportPosition.z, 0.0f, 1.0f);

        Debug.Log(viewportPosition);
        transform.position = mainCamera.ViewportToWorldPoint(viewportPosition);
        */





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

    public abstract void Shoot();

    protected void ChooseBullet(int index)
    {
        Vector3 temp = transform.localPosition;
        temp.z += 1.9f;
        switch (index)
        {
            case 0:
                bullet = bulletFactory.CreateBullet("LaserBullet", temp);
                break;
            case 1:
                bullet = bulletFactory.CreateBullet("ThrowingBullet", temp);
                break;
            case 2:
                bullet = bulletFactory.CreateBullet("ExplosiveBullet", temp);
                break;
            default:
                bullet = bulletFactory.CreateBullet("LaserBullet", temp);
                break;


                bullet.SetActive(true);
        }

    }


}

