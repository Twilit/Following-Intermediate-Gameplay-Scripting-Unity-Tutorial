using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyMSomeScript : MonoBehaviour
{

	void Start ()
    {
        PolyMParentClass myClass = new PolyMChildClass();

        myClass.ParentMethod();

        ((PolyMChildClass)myClass).ChildMethod();

        PolyMChildClass myChild = (PolyMChildClass)myClass;

        myChild.ChildMethod();
	}

}
