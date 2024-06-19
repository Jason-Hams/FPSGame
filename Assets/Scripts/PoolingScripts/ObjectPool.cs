using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private List<PooledObjects> availableObjects = new List<PooledObjects>();
    [SerializeField] private PooledObjects originalObjects;
    [SerializeField] private int amountOfCopies;

    private void Awake()
    {
        for(int index = 0; index < amountOfCopies; index++)
        {
            CreateACopy();
        }
    }

    private void CreateACopy()
    {
        PooledObjects tempObject = Instantiate(originalObjects, transform);
        tempObject.LinkToPool(this);
        tempObject.gameObject.SetActive(false);
        availableObjects.Add(tempObject);
    }


    public PooledObjects RetrieveAvailableItem()
    {
        if(availableObjects.Count == 0)
        {
            CreateACopy();
        }
       
        PooledObjects tempObject = availableObjects[0];
        availableObjects.RemoveAt(0);
        tempObject.gameObject.SetActive(true);

        return tempObject;
    }

    public void ResetBullet(PooledObjects cloneObject)
    {
        cloneObject.gameObject.SetActive(false);
        availableObjects.Add(cloneObject);
    }

}
