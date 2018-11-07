using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesPlayer : MonoBehaviour
{

    private int exp;

    public int Exp
    {
        get
        {
            return exp;
        }

        set
        {
            exp = value;
        }
    }

}
