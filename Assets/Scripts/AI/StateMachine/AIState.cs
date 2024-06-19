using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIState
{
    protected AiController controller;
    public AIState(AiController contr)
    {
        controller = contr;
    }
    
    public abstract void OnStateEnter();
    

    public abstract void OnStateRun();
    

    public abstract void OnStateExit();
    
}
