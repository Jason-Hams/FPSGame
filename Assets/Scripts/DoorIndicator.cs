using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorIndicator : MonoBehaviour, IInteractable

{
    [SerializeField] private UnityEvent onInteracted;
    [SerializeField] private Material highlightedMaterial;

    private bool isUnlocked = false;
    private Material orignalMaterial;
    private MeshRenderer mesh;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        orignalMaterial = mesh.material;

    }
    public void OnHoverEnter()
    {
        if (!isUnlocked) return;
        mesh.material = highlightedMaterial;
        Debug.Log("looking at button");
    }

    public void OnHoverExit()
    {
        if (!isUnlocked) return;
        mesh.material = orignalMaterial;
        Debug.Log("not looking anymore");
    }

    public void OnInteract(InteractModule module)
    {
        if (!isUnlocked) return;
        onInteracted.Invoke();
        Debug.Log("interacted with button");
    }

    public void unlockdoor() 
    {
        isUnlocked = true;
    }
}
