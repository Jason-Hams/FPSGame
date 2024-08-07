using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public TurretState currentState { get; private set; }
    public TurretVision turretVision { get; private set; }
    [field: SerializeField] public float dmgPerSec { get; private set; } = 10f;

    void Start()
    {
        currentState = new TurretIdleState(this);
        currentState.OnStateEnter();
    }
    void Update()
    {
        currentState.OnStateRun();
    }
    public void ChangeState(TurretState state)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }
        currentState = state;
        currentState.OnStateEnter();
    }
    public void LinkToTurretVision(TurretVision turretVision)
    {
        this.turretVision = turretVision;
    }
}
