using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

	void Start ()
    {
        Player myPlayer = new Player();

        myPlayer.Exp = 5;

        int x = myPlayer.Exp;
	}
}
