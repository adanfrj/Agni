using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int maxHealthEnemy = 3;
    public int currentHealthEnemy;

    public EnemyHealthBar healthBarEnemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealthEnemy = maxHealthEnemy;
        healthBarEnemy.SetEnemyMaxHealth(maxHealthEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamagePlayer(int damage)
    {
        currentHealthEnemy -= damage;
        healthBarEnemy.SetEnemyHealth(currentHealthEnemy);
    }

    void OnCollisionEnter2D (Collision2D player)
    {
       if (player.transform.CompareTag("Player"))
       {
           TakeDamagePlayer(1);
       }
    }
}
