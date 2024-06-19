using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommandGiver : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Camera Camera;
    [SerializeField] private LayerMask clickableLayer;
    [SerializeField] private Queue<Command> commands = new Queue<Command>();

    private Command currentCommand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentCommand != null)
        {
            currentCommand.Execute();
            if (currentCommand.IsCompleted())
            {
               

            }
        }
        else
        {
            if (commands.Count == 0)
            {
                return;
            }
            currentCommand = commands.Dequeue();
            
        }
        

        
       

    }

    public void CreateCommands()
    {
        Ray ray = Camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 5f, clickableLayer))
        {
            //Instantiate(guidance, hit.point, Quaternion.identity);
          
            commands.Enqueue(new MoveCommand(agent, hit.point));
        }
        
    }
}
