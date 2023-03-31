using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class script: MonoBehaviour
{
    public float moveSpeed = 5.0f;
    
    public static int Damage = 1;
    private Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rigidbody2d.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);

        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerHealth playerHealth = GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(Damage);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}