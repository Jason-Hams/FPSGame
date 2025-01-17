using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : AIState
{
    [SerializeField] private int wayPointIndex;

    public PatrolState(AiController contr) : base(contr)
    {

    }

    public override void OnStateEnter()
    {
        controller.GetAgent().SetDestination(controller.GetPath()[wayPointIndex].position);
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateRun()
    {
        if (controller.GetAgent().remainingDistance <= controller.GetAgent().stoppingDistance)
        {
            wayPointIndex++;
            if (wayPointIndex >= controller.GetPath().Length)
            {
                wayPointIndex = 0;
            }
            controller.GetAgent().SetDestination(controller.GetPath()[wayPointIndex].position);
        }

    }
}
