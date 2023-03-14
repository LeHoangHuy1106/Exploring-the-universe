using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseDecorator : SkillBasic // tăng tốc
{
    private GameObject itemDefense;
    // Start is called before the first frame update
    public DefenseDecorator(ISkill skill, GameObject itemDefense)
    {
        this.itemDefense = itemDefense;
    }

    public override void TurnOff()
    {
        itemDefense.SetActive(false);
        base.TurnOff();
    }

    public override void TurnOn()
    {
        itemDefense.SetActive(true);
        base.TurnOn();
    }
}

