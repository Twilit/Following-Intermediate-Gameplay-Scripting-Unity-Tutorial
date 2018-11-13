using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColour : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += TurnColourMethod;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= TurnColourMethod;
    }

    void TurnColourMethod()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        //renderer.material.color = col;
    }
}
