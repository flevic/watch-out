using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    public GameObject enemy;
    public int maxHealth = 10;
    public int currentHealth;
    public int damage = 10;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    


public void EnemyTakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            EnemyDie();
        }
        




    }
    

    private void EnemyDie()
    {
        
        Destroy(enemy, 0.1f);

    }
}