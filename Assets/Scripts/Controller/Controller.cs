using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{


    string[] lisEnemy = new string[] { "Rock1", "Rock2", "Rock3", "Aircraft", "Econnaissance", "Battleship" };
    string[] listStar = new string[] { "StarRed", "StarBlue", "StarYellow", "HP" };



    // Start is called before the first frame update
    [SerializeField]
    private GameObject laserBullet, throwingBullet, explosiveBullet;
    [SerializeField]
    private GameObject rock1, rock2, rock3;
    [SerializeField]
    private GameObject aircraft, econnaissance, aircraftBullet, battleship, spaceshipBullet;
    [SerializeField]
    private GameObject boom1, boom2, boom3, yelowBoom;
    [SerializeField]
    private GameObject starRed, starBlue, starYellow, HP;
    [SerializeField]
    private int n = 2;
    int index;
    float ratio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CallEnemy());
        StartCoroutine(CallStar());
        CreateObjectPool(n);
        ratio = (float)Screen.width / (float)Screen.height;


    }
    private void Update()
    {
    }
    void CreateObjectPool(int n)
    {
        Debug.Log("hhe");
        ObjectPool.Instance.CreateListObject("LaserBullet", laserBullet, n);
        ObjectPool.Instance.CreateListObject("ThrowingBullet", throwingBullet, n);
        ObjectPool.Instance.CreateListObject("ExplosiveBullet", explosiveBullet, n);
        ObjectPool.Instance.CreateListObject("Rock1", rock1, n);
        ObjectPool.Instance.CreateListObject("Rock2", rock2, n);
        ObjectPool.Instance.CreateListObject("Rock3", rock3, n);
        ObjectPool.Instance.CreateListObject("Aircraft", aircraft, n);
        ObjectPool.Instance.CreateListObject("Econnaissance", econnaissance, n);
        ObjectPool.Instance.CreateListObject("AircraftBullet", aircraftBullet, n);
        ObjectPool.Instance.CreateListObject("Boom1", boom1, n);
        ObjectPool.Instance.CreateListObject("Boom2", boom2, n);
        ObjectPool.Instance.CreateListObject("Boom3", boom3, n);
        ObjectPool.Instance.CreateListObject("YellowBoom", yelowBoom, n);
        ObjectPool.Instance.CreateListObject("StarRed", starRed, n);
        ObjectPool.Instance.CreateListObject("StarBlue", starBlue, n);
        ObjectPool.Instance.CreateListObject("StarYellow", starYellow, n);
        ObjectPool.Instance.CreateListObject("Battleship", battleship, n);
        ObjectPool.Instance.CreateListObject("SpaceshipBullet", spaceshipBullet, n);
        ObjectPool.Instance.CreateListObject("HP", HP, n);
    }

    IEnumerator CallEnemy()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        index = Random.RandomRange(0, lisEnemy.Length);

        GameObject enemy = ObjectPool.Instance.GetObject(lisEnemy[index]);
        enemy.transform.position = new Vector3(Random.Range(-14.5f * ratio, 14.5f * ratio), 30, 3);
        if (index == 5 && Random.RandomRange(1, 6) <=2)
        {
            enemy.SetActive(true);
        }
        else if(index<5)
         {
            enemy.SetActive(true);
        }

        if (index <= 2)
        {
            enemy.transform.localScale = (Vector3.one * Random.RandomRange(1, 4));
        }

        StartCoroutine(CallEnemy());

    }

    IEnumerator CallStar()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        index = Random.RandomRange(0, listStar.Length);

        GameObject enemy = ObjectPool.Instance.GetObject(listStar[index]);
        enemy.transform.position = new Vector3(Random.Range(-15 * ratio, 15 * ratio), 30, 1);
        enemy.SetActive(true);
        StartCoroutine(CallStar());
    }


}
