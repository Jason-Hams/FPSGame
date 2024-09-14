using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthModule : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float currentHealth;

    public Action<float> onHealthChanged;
    public Action OnDie;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

  

    public void DeductHealth(float toDeduct)
    {
        currentHealth -= toDeduct;
        onHealthChanged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            GameManager.Singleton.PlayerDie();
            currentHealth = maxHealth;
            OnDie?.Invoke();
        }
    }
}
