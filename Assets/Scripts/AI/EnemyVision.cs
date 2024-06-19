using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    [SerializeField] private AiController myController;
    private void OnTriggerEnter(Collider other)
    {
        myController.ChangeState(new ChaseState(myController, other.transform));
    }

    private void OnTriggerExit(Collider other)
    {
        myController.ChangeState(new PatrolState(myController));
    }
}
