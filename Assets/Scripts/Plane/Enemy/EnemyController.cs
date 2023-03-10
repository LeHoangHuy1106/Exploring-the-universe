using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    [SerializeField]
    ObjectPool objectPool;
    string[] listName = new string[] { "Rock1", "Rock2", "Rock3", "Aircraft", "Econnaissance" };
    int index;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CallEnemy());

    }

    // Update is called once per frame


    IEnumerator CallEnemy()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        index = Random.RandomRange(0, listName.Length);

        GameObject enemy = objectPool.GetObject(listName[index]);
        enemy.transform.position = new Vector3(Random.Range(-23f, 23f), 30, 1);
        enemy.active = true;
       if (index <=2)
        {
            enemy.transform.localScale= (Vector3.one * Random.RandomRange(1, 4));
        }    
        StartCoroutine(CallEnemy());
    }
}
