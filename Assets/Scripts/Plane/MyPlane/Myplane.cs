using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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

    [SerializeField]
    private GameObject gunUpdate;


    public void Collision(Collision collision)
    {
        if (collision.gameObject.CompareTag("PHP"))
        {
            ScoreCotroller.GetInstance().SetScore("hp", 1);
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("PRed"))
        {
            ScoreCotroller.GetInstance().SetScore("red", 10);
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("PBlue"))
        {
            ScoreCotroller.GetInstance().SetScore("blue", 5);
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("PYellow"))
        {
            ScoreCotroller.GetInstance().SetScore("yellow", 2);
            collision.gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag("E1"))
        {
            ScoreCotroller.GetInstance().SetScore("hp", -1);
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



        float ratio = (float)Screen.width / (float)Screen.height;
  
        Vector3 T = transform.position;
        T.x = Mathf.Clamp(T.x, -15 * ratio, 15 * ratio);
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

        Debug.Log("kt:" + ScoreCotroller.GetInstance().GetScore("red"));

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
                if (ScoreCotroller.GetInstance().GetScore("red") >= 1)
                {
                    bullet = bulletFactory.CreateBullet("LaserBullet", temp);
                    ScoreCotroller.GetInstance().SetScore("red", -1);
                    BulletUpGradedGun(gunUpdate.activeInHierarchy);
                }

                break;
            case 1:
                if (ScoreCotroller.GetInstance().GetScore("blue") >= 1)
                {
                    bullet = bulletFactory.CreateBullet("ThrowingBullet", temp);
                    ScoreCotroller.GetInstance().SetScore("blue", -1);
                }
                break;
            case 2:
                if (ScoreCotroller.GetInstance().GetScore("yellow") >= 1)
                {
                    ScoreCotroller.GetInstance().SetScore("yellow", -1);
                    bullet = bulletFactory.CreateBullet("ExplosiveBullet", temp);
                }
                break;
            default:
                if (ScoreCotroller.GetInstance().GetScore("red") >= 1)
                {
                    Debug.Log("chon da vang");
                    bullet = bulletFactory.CreateBullet("LaserBullet", temp);
                    ScoreCotroller.GetInstance().SetScore("red", -1);
                    BulletUpGradedGun(gunUpdate.activeInHierarchy);
                }
                break;


                bullet.SetActive(true);
        }

    }
    protected void BulletUpGradedGun(bool check)
    {

        if (check && ScoreCotroller.GetInstance().GetScore("red") >= 3)
        {

            GameObject bullet = bulletFactory.CreateBullet("LaserBullet", transform.position);
            bullet.transform.eulerAngles = new Vector3(90f, 0f, 45f);
            bullet.SetActive(true);
            Debug.Log(bullet.transform.rotation.eulerAngles);


            bullet = bulletFactory.CreateBullet("LaserBullet", transform.position);
            bullet.transform.eulerAngles = new Vector3(90f, 0f, -45f);
            bullet.SetActive(true);
            Debug.Log(bullet.transform.rotation.eulerAngles);


            ScoreCotroller.GetInstance().SetScore("red", -2);

        }
    }

}

