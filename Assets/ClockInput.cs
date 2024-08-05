using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockInput : MonoBehaviour
{
    [SerializeField]  int value; 
    ClockPuzzleController Controller;
    [SerializeField] Transform ClockPivot;
    bool AllowPlayerInput = true;
    [SerializeField] Renderer Meshrender;
    [SerializeField] Material HitMaterial;
    Material originalMaterial;

 
    public void LinkToController(ClockPuzzleController Controller, int value)
    {
        this.value = value;
        this.Controller = Controller;
    }

    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = Meshrender.material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!AllowPlayerInput) return;
        Meshrender.material = HitMaterial;
        Controller.onPlayerInput(value);
        Debug.Log(value);
       
    }

    public void SetClockHands(float Percent)

    {
        Quaternion NewRotation = Quaternion.Euler(0, 0, Percent * -360f);
        ClockPivot.localRotation = NewRotation;
        Meshrender.material = originalMaterial;
    }

    public void DisablePlayerInput()
    {
        AllowPlayerInput = false;
        
    }
}
