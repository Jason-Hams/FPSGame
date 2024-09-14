using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
    [SerializeField] GameObject GameOverCanvas;
    
// Start is called before the first frame update
    void Start()
    {
        GameManager.Singleton.OnPlayerDied.AddListener(PlayerDied);
    }

    private void PlayerDied ()
    {
    GameOverCanvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnRespawn()
    {
        Debug.Log("respawn");
        GameManager.Singleton.PlayerRespawn();
        GameOverCanvas.gameObject.SetActive(false);
    }
}
