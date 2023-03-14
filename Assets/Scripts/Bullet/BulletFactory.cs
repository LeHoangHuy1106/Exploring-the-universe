using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
  
    public BulletFactory ()
    {
        
    }

    public GameObject CreateBullet(string name, Vector3 position)
    {
        GameObject bullet = ObjectPool.Instance.GetObject(name);
        bullet.transform.position = position;
        bullet.SetActive(true);
        return bullet;
    }
}
