using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorKey : MonoBehaviour
{
    public UnityEvent onpickup = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i picked up key");
        onpickup.Invoke();
        Destroy(gameObject);
    }
}
