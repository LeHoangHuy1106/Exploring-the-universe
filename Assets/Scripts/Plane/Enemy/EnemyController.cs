using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    [SerializeField]
    ObjectPool objectPool;
    string[] lisEnemy = new string[] { "Rock1", "Rock2", "Rock3", "Aircraft", "Econnaissance" };
    string[] listStar = new string[] { "StarRed", "StarBlue", "StarYellow" };

    int index;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CallEnemy());
        StartCoroutine(CallStar());

    }

    // Update is called once per frame


    IEnumerator CallEnemy()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        index = Random.RandomRange(0, lisEnemy.Length);

        GameObject enemy = objectPool.GetObject(lisEnemy[index]);
        enemy.transform.position = new Vector3(Random.Range(-23f, 23f), 30, 1);
        enemy.active = true;
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

        GameObject enemy = objectPool.GetObject(listStar[index]);
        enemy.transform.position = new Vector3(Random.Range(-23f, 23f), 30, 1);
        enemy.SetActive ( true);
        StartCoroutine(CallStar());
    }
}
