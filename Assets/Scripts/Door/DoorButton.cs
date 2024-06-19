using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorButton : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent onInteracted;
    [SerializeField] private Material highlightedMaterial;

    private Material orignalMaterial;
    private MeshRenderer mesh;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        orignalMaterial = mesh.material;
        
    }
    public void OnHoverEnter()
    {
        mesh.material = highlightedMaterial;
        Debug.Log("looking at button");
    }

    public void OnHoverExit()
    {
        mesh.material = orignalMaterial;
        Debug.Log("not looking anymore");
    }

    public void OnInteract(InteractModule module)
    {
        onInteracted.Invoke();
        Debug.Log("interacted with button");
    }
}
