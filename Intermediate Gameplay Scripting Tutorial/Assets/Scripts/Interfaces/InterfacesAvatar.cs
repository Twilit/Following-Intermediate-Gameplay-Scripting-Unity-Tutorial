using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacesAvatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Kill()
    {
        //Do something
    }

    public void Damage(float damage)
    {
        //Do something
    }
}
