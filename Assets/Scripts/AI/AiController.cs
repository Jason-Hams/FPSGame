using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    [SerializeField] private Transform[] targets;
    [SerializeField] private NavMeshAgent agent;

    public AIState currentState;
    // Start is called before the first frame update
    void Start()
    {
        ChangeState(new PatrolState(this));
    }

    // Update is called once per frame
    void Update()
    {

        currentState.OnStateRun();

    }

    public void ChangeState(AIState state)
    {
        if(currentState != null)
        {
            currentState.OnStateExit();
        }

        currentState = state;
        currentState.OnStateEnter();
    }

    public NavMeshAgent GetAgent()
    {
        return agent;
    }

    public Transform[] GetPath()
    {
        return targets;
    }
}
