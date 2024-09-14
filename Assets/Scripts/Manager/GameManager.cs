using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Singleton { get; private set; }

    private InputController player;

    public UnityEvent OnActionLevelStart;
    public UnityEvent OnActionLevelEnds;
    public UnityEvent OnPlayerDied; 

    private void Awake()
        {
        
        Singleton=this;

        
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
        
        OnPlayerDied.Invoke(); 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;

    }

    


    public void PlayerRespawn()
    {
        Time.timeScale = 1;
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = Respawn.Singleton.GetRespawn().position;
        player.GetComponent<CharacterController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
