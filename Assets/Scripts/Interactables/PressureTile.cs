using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressureTile : MonoBehaviour
{
    [SerializeField] private UnityEvent onActivation;
    [SerializeField] private UnityEvent onDeactivation;
    [SerializeField] private Rigidbody correctRigidbody;


    private void OnTriggerEnter(Collider other)
    {

        if(other.attachedRigidbody == correctRigidbody)
        {
            onActivation.Invoke();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody == correctRigidbody)
        {
            onDeactivation.Invoke();
        }
    }
}
