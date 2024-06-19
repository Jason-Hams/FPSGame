using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 doorOpenOffset;
    [SerializeField] private float openingSpeed;

    private Vector3 doorOriginalPosition;
    private bool isOpening;

    private void Start()
    {
        doorOriginalPosition = transform.position;
    }
    private void Update()
    {
        Vector3 targetPosition = doorOriginalPosition;
        if(isOpening)
        {
            targetPosition = doorOriginalPosition + doorOpenOffset;
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, openingSpeed * Time.deltaTime);
    }

    public void OpenDoor()
    {
        isOpening = true;
    }

    public void CloseDoor()
    {
        isOpening = false;
    }
}
