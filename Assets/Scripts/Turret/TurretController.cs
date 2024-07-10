using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{

    public TurretState currentState;
    // Start is called before the first frame update
    void Start()
    {
        ChangeState(new TurretIdleState(this));
    }

    // Update is called once per frame
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

    

}
