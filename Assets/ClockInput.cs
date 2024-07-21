using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockInput : MonoBehaviour
{
    [SerializeField]  int value; 
    ClockPuzzleController Controller;

    public void LinkToController(ClockPuzzleController Controller, int value)
    {
        this.value = value;
        this.Controller = Controller;
    }

    // Start is called before the first frame update
