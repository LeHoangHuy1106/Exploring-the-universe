using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject laserBullet, throwingBullet, explosiveBullet;
    [SerializeField]
    private GameObject rock1, rock2, rock3;
    [SerializeField]
    private GameObject aircraft, econnaissance, aircraftBullet, battleship, spaceshipBullet;
    [SerializeField]
    private GameObject boom1, boom2,boom3, yelowBoom;
    [SerializeField]
    private GameObject starRed, starBlue, starYellow, HP;

    [SerializeField]
    private int n = 2;


    Dictionary<string, Queue<GameObject>> dictQueue = new Dictionary<string, Queue<GameObject>>();

    void Start()
    {
        CreateListObject("LaserBullet", laserBullet, n);
        CreateListObject("ThrowingBullet", throwingBullet,n);
        CreateListObject("ExplosiveBullet", explosiveBullet, n);
        CreateListObject("Rock1", rock1, n);
        CreateListObject("Rock2", rock2, n);
        CreateListObject("Rock3", rock3, n);
        CreateListObject("Aircraft", aircraft, n);
        CreateListObject("Econnaissance", econnaissance, n);
        CreateListObject("AircraftBullet", aircraftBullet, n);
        CreateListObject("Boom1", boom1, n);
        CreateListObject("Boom2", boom2, n);
        CreateListObject("Boom3", boom3, n);
        CreateListObject("YellowBoom", yelowBoom, n);
        CreateListObject("StarRed", starRed , n);
        CreateListObject("StarBlue", starBlue, n);
        CreateListObject("StarYellow", starYellow, n);
        CreateListObject("Battleship", battleship, n);
        CreateListObject("SpaceshipBullet", spaceshipBullet, n);
        
    }


    void CreateListObject(string name, GameObject gameObject, int n)
    {


        Queue<GameObject> queueObject = new Queue<GameObject>();


        for (int i = 0; i < n; i++)
        {
            GameObject obj = Instantiate(gameObject);
            obj.SetActive(false);
            queueObject.Enqueue(obj);
        }
        dictQueue[name] = queueObject;

        return;
    }


    public GameObject GetObject(string name)
    {
        GameObject obj;
        int count = dictQueue[name].Count;
        while (count>= 0)
        {
            obj = dictQueue[name].Dequeue();
            count--;
            if (!obj.active)
            {
               dictQueue[name].Enqueue(obj);
               return obj;
            }
            dictQueue[name].Enqueue(obj);
        }
        obj = Instantiate(dictQueue[name].Peek());
        obj.SetActive(false);
        dictQueue[name].Enqueue(obj);
        return obj;
    }



}








