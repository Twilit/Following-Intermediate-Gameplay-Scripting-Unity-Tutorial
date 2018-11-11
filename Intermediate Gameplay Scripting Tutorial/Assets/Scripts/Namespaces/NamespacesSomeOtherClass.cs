using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SampleNamespace;

namespace SampleNamespace
{
    public class NamespacesSomeOtherClass : MonoBehaviour
    {

        void Start()
        {
            //SampleNamespace.NamespacesSomeClass myClass = new SampleNamespace.NamespacesSomeClass();

            NamespacesSomeClass myClass = new NamespacesSomeClass();
        }

    }
}