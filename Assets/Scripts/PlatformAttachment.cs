using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttachment : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("player has entered");
        if (other.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }

}

