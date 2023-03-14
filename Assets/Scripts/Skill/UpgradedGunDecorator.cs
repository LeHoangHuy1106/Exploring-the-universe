using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradedGunDecorator : SkillBasic // tăng tốc
{
    private GameObject itemUpgradedGun;
    // Start is called before the first frame update
    public UpgradedGunDecorator(ISkill skill, GameObject itemUpgradedGun) 
    {
        this.itemUpgradedGun = itemUpgradedGun;
    }

    public override void TurnOff()
    {
        itemUpgradedGun.SetActive(false);
        base.TurnOff();
    }

    public override void TurnOn()
    {
        itemUpgradedGun.SetActive(true);
        base.TurnOn();
    }
}
