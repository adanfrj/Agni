using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    private LevelCheckpoint levelCheckpoint;
    public GameObject checkpointLight;

    private void  OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkpointLight.SetActive(true);
            levelCheckpoint.PlayerThroughCheckpoint(this);
        }
    }

    public void SetLevelCheckpoint(LevelCheckpoint levelCheckpoint)
    {
        this.levelCheckpoint = levelCheckpoint;
    }
}
