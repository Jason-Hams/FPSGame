using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton { get; private set; }

    private InputController player;

    public UnityEvent OnActionLevelStart;
    public UnityEvent OnActionLevelEnds;

    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
    }
    private void Start()
    {
        StartLevel();
    }



    public void StartLevel()
    {
        Debug.Log("Level Started");
        player = FindObjectOfType<InputController>();

        OnActionLevelStart?.Invoke();
    }

    public void FinishLevel()
    {
        Debug.Log("Level Finished");
        OnActionLevelEnds?.Invoke();
    }

    public void PlayerDie()
    {
        Debug.Log("Player Died");
    }

    public void LockPlayerInput()
    {
        player.enabled = false;
    }

    public void UnlockPlayerInput()
    {
        player.enabled = true;
    }

}
