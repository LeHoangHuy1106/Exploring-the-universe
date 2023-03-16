using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUpgradedGun : MonoBehaviour
{

    bool isSkill = false;

    BulletFactory bulletFactory = new BulletFactory();


    private void OnEnable()
    {
        isSkill = true;
    }
    private void OnDisable()
    {
        isSkill = false;
    }



}
