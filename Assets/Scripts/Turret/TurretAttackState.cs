using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAttackState : TurretState
{
    HealthModule Health;

    public TurretAttackState(TurretController contr, HealthModule Health) : base(contr)
    {
        this.Health = Health;
    }

    public override void OnStateEnter()
    {
        
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateRun()
    {
        Health.DeductHealth(controller.dmgPerSec* Time.deltaTime);
    }
}

