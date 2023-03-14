using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationDecorator : SkillBasic  //tăng tốc
{
    private GameObject itemAcceleration;
    // Start is called before the first frame update
    public AccelerationDecorator(ISkill skill, GameObject itemAcceleration) 
    {
        this.itemAcceleration = itemAcceleration;
    }

    public override void TurnOff()
    {
        itemAcceleration.SetActive(false);
        base.TurnOff();
    }

    public override void TurnOn()
    {
        itemAcceleration.SetActive(true);
        base.TurnOn();
    }
}
