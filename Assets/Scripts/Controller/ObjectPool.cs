using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{


    Dictionary<string, Queue<GameObject>> dictQueue = new Dictionary<string, Queue<GameObject>>();

    private static ObjectPool instance = null;

    public static ObjectPool Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Other methods and variables can be added here




    public void CreateListObject(string name, GameObject gameObject, int n)
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








