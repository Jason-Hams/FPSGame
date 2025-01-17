using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCommand : Command
{
    private NavMeshAgent agentToCommand;
    private Vector3 destination;
    private bool arrivedAtDestination;

    public override void Execute()
    {
        agentToCommand.SetDestination(destination);
        if(agentToCommand.remainingDistance < 0.2f)
        {
            arrivedAtDestination = true;
        }
    }

    public override bool IsCompleted()
    {
        return arrivedAtDestination;
    }

    public MoveCommand(NavMeshAgent agent, Vector3 position)
    {
        agentToCommand = agent;
        destination = position;
    }
}
