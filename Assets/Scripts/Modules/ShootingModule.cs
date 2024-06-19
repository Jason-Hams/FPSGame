using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingModule : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;

    [Header("Shooting")]
    [SerializeField] private Camera Camera;
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private Transform shootingPoint;
   

  
    public void Shoot()
    {
        PooledObjects tempPooled = pool.RetrieveAvailableItem();

        Rigidbody bulletinstantiated = tempPooled.rigidBod;

        bulletinstantiated.position = shootingPoint.position;
        bulletinstantiated.rotation = shootingPoint.rotation;    
        bulletinstantiated.AddForce(10f * Camera.transform.forward, ForceMode.Impulse);
        tempPooled.ResetBackToPool(5f);
        

    }

}
