using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTunnel : MonoBehaviour
{
    [SerializeField]
    Behaviour lightR, lightL;


    private void OnTriggerEnter(Collider other)
    {
        lightR.enabled = true;
        lightL.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        lightR.enabled = false;
        lightL.enabled = false;
    }

}
