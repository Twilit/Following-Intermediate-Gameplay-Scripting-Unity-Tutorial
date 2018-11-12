using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDBadGuy : IComparable<LDBadGuy>
{
    public string name;
    public int power;

    public LDBadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    public int CompareTo(LDBadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        return power - other.power;
    }
}
