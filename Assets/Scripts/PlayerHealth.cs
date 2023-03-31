using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public GameObject heart5;
    public GameObject player;
    public int maxHealth = 1;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
     
    }
    
    

    private void Die()
    {
        Destroy(heart5, 0.1f);
        Destroy(player, 0.1f);
        
    }
}
