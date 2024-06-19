using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObjects : MonoBehaviour
{
    public Rigidbody rigidBod;
    private ObjectPool poolOwner;
    private float timerToReset;
    private bool reseting;

    public void LinkToPool(ObjectPool owner)
    {
        poolOwner = owner;
    }


    public void ResetBackToPool()
    {
        rigidBod.velocity = Vector3.zero;
        reseting = false;
        poolOwner.ResetBullet(this);

    }

    public void ResetBackToPool(float time)
    {
        timerToReset = time;
        reseting = true;
    }



    // Update is called once per frame
    void Update()
    {
        if(reseting)
        {
            timerToReset -= Time.deltaTime;
            if(timerToReset <= 0)
            {
                ResetBackToPool();
            }
        }
    }
}
