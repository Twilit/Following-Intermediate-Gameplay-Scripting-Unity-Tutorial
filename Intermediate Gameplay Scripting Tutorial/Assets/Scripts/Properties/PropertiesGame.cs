using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesGame : MonoBehaviour
{

	void Start ()
    {
        PropertiesPlayer myPlayer = new PropertiesPlayer();

        myPlayer.Exp = 5;

        int x = myPlayer.Exp;
	}
	
}
