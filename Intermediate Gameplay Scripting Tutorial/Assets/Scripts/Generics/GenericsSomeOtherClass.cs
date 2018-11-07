using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsSomeOtherClass : MonoBehaviour
{

	void Start ()
    {
        GenericsSomeClass myClass = new GenericsSomeClass();

        myClass.GenericMethod<int>(5);
	}

}
