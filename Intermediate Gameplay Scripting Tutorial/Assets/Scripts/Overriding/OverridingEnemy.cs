using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverridingEnemy : OverridingHumanoid
{

    public override void Yell()
    {
        base.Yell();
        //Attract nearby enemies
    }

}
