using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthBar;
 
    private Vector3 respawnPoint;
    public GameObject gameOver;
    public Transform respawn;

    private Animator anim;
    public static bool sceneFreeze = false;
    private CharacterSoundController sound;
    private BatSoundController batSound;
    private WolfSoundController wolfSound;
    private BossSoundController bossSound;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        respawnPoint = respawn.transform.position;
        gameOver.SetActive(false);

        anim = gameObject.GetComponent<Animator>();
        sound = GetComponent<CharacterSoundController>();
        batSound = GetComponent<BatSoundController>();
        wolfSound = GetComponent<WolfSoundController>();
        bossSound = GetComponent<BossSoundController>();
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
            respawnPoint = respawn.transform.position;;
            currentHealth = maxHealth;
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            sceneFreeze = true;
        }

        anim.SetBool("isLowHealth", true);
    }

    void OnCollisionEnter (Collision enemy)
    {
       if (enemy.transform.CompareTag("Enemy"))
       {
           TakeDamage(1);
           sound.Hit();
           batSound.Attack();
       }

       if(enemy.transform.CompareTag("Wolf"))
       {
           TakeDamage(1);
           wolfSound.AttackWolf();
       }

       if(enemy.transform.CompareTag("Boss"))
       {
           TakeDamage(1);
           bossSound.Attack();
       }

     
    }

    
}
