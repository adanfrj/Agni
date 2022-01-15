using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager gm;
    public Transform respawnPoint;
    public Transform playerPrefab;


    void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("Level Manager").GetComponent<LevelManager>();
        }
    }

    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, respawnPoint.rotation);
        Debug.Log("TODO : Add Spawn Particles");
    }

    public static void KillPlayer (PlayerStats player)
    {
        Destroy (player.gameObject);
        gm.Respawn();
    }

}
