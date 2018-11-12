using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDSomeClass : MonoBehaviour
{


	void Start ()
	{
        List<LDBadGuy> badGuys = new List<LDBadGuy>();

        badGuys.Add(new LDBadGuy("Harvey", 50));
        badGuys.Add(new LDBadGuy("Magneto", 100));
        badGuys.Add(new LDBadGuy("Pip", 5));

        badGuys.Sort();
	}
}
