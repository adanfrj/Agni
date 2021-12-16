using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;

    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            transform.position = respawnPoint;
            currentHealth = maxHealth;
        }

      
    }

    void OnCollisionEnter2D (Collision2D enemy)
    {
       if (enemy.transform.CompareTag("Enemy"))
       {
           TakeDamage(1);
       }
    }
}
