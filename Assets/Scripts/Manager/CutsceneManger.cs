using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManger : MonoBehaviour
{
    [SerializeField] private PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager.Singleton.OnActionLevelStart += StartCutscene;  

        
    }


    private void StartCutscene()
    {
        GameManager.Singleton.LockPlayerInput();
        director.Play();
    }

    public void EndCutscene()
    {
        
        GameManager.Singleton.UnlockPlayerInput();
       // GameManager.Singleton.OnActionLevelStart -= StartCutscene;
    }
}
