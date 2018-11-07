using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOSomeOtherClass : MonoBehaviour
{

	void Start ()
    {
        MOSomeClass myClass = new MOSomeClass();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
	}

}
