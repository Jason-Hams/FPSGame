using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyInSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float time = 10;
    
    void Start()
    {
        Invoke("delete", time);
    }

   public void delete()
    {
        Destroy(gameObject);
    }

}
