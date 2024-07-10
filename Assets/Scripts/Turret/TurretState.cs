using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretState 
{

    protected TurretController controller;
    public TurretState(TurretController contr)
    {
        controller = contr;
    }

    public abstract void OnStateEnter();


    public abstract void OnStateRun();


    public abstract void OnStateExit();
}
