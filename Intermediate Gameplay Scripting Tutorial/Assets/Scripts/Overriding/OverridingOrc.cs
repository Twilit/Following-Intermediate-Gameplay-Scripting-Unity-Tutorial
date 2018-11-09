using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverridingOrc : OverridingEnemy
{

    public override void Yell()
    {
        base.Yell();
        //Power up nearby orcs
    } 

}
