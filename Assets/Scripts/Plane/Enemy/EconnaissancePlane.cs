using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconnaissancePlane :Enemy
{

    

    float time;
    [SerializeField]
    Transform player;
    public override void Moving()
    {
       
        if (player)
        {
            if (player)
            {
                Vector3 direction = player.transform.localPosition - transform.localPosition;
                Vector3 velocity = direction.normalized * GetSpeed();
                rb.velocity = velocity;
            }
        }
    }
        

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(1f, 2f);
       
        InvokeRepeating("Moving", 1f, time);
    }

    // Update is called once per frame
    void Update()
    {
        Limit();
        if (player)
        {
            transform.LookAt(player.transform);
        }
    }
}
