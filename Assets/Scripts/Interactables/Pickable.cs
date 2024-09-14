using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, IInteractable
{
    private Transform point;
    [SerializeField] private Rigidbody rigidBod;

    public void OnHoverEnter()
    {
        
    }

    public void OnHoverExit()
    {
       
    }

    public void OnInteract(InteractModule module)
    {
        if (transform.parent == null)
        {
            rigidBod.useGravity = false;
            rigidBod.isKinematic = true;

            point = module.GetHoldTransform();
            transform.position = module.GetHoldTransform().position;
            transform.rotation = module.GetHoldTransform().rotation;
            transform.SetParent(point);
         
          
        }
        else
        {
            rigidBod.useGravity = true;
            rigidBod.isKinematic = false;

            transform.SetParent(null);

        }


    }

    private void PickUp()
    {
    
    }

    private void drop()
    {

    }
}
