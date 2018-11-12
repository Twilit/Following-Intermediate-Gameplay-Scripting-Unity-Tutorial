using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDSomeOtherClass : MonoBehaviour
{


	void Start ()
	{
        Dictionary<string, LDBadGuy> badGuys = new Dictionary<string, LDBadGuy>();

        LDBadGuy bg1 = new LDBadGuy("Harvey", 50);
        LDBadGuy bg2 = new LDBadGuy("Magneto", 100);

        badGuys.Add("gangster", bg1);
        badGuys.Add("mutant", bg2);

        LDBadGuy magneto = badGuys["mutant"];

        LDBadGuy temp = null;

        if (badGuys.TryGetValue("birds", out temp))
        {
            //success
        }
        else
        {
            //failure
        }
	}
}
