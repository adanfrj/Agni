using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //prefab instantiate
    public GameObject enemy;

    private Rigidbody2D rb;

    public float respawnTime = 2f;

    //next spawn time
    float nextSpawn = 0f;

    void Start()
    {

    }

    private void Enemy()
    {
        GameObject ene = Instantiate(enemy) as GameObject;
        ene.transform.position = new Vector2(Random.Range(-1f, 1f), Random.Range(-2f, 2f));
    }

    public IEnumerator CubeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Enemy();
        }
    }
}
