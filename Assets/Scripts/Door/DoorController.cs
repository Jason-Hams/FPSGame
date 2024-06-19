using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void OpenDoor()
    {
        animator.SetBool("DoorOpen", true);
    }

    public void CloseDoor()
    {
        animator.SetBool("DoorOpen", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("DoorOpen", true);
    }
}
