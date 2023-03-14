using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeDecorator : SkillBasic // tăng tốc
{
    private GameObject itemSlowTime;
    // Start is called before the first frame update
    public SlowTimeDecorator(ISkill skill, GameObject itemSlowTime)
    {
        this.itemSlowTime = itemSlowTime;
    }

    public override void TurnOff()
    {
        itemSlowTime.SetActive(false);
        base.TurnOff();
    }

    public override void TurnOn()
    {
        itemSlowTime.SetActive(true);
        base.TurnOn();
    }
}
