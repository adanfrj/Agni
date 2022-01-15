using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    private EnemyAI enemyMove;

    void Start()
    {
        enemyMove = GetComponent<EnemyAI>();
    }

    void OnTriggerEnter (Collider other)
    {
       if(other.gameObject.CompareTag("Flash"))
       {
           enemyMove.enabled = false;
       }
       else 
       {
           enemyMove.enabled = true;
       }
    }
}
