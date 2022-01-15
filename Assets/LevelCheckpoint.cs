using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckpoint : MonoBehaviour
{
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        foreach (Transform checkpointTransform in checkpointsTransform)
        {
            PlayerCheckpoint checkpoint = checkpointTransform.GetComponent<PlayerCheckpoint>();
            checkpoint.SetLevelCheckpoint(this);
        }
    }

    public void PlayerThroughCheckpoint(PlayerCheckpoint checkpoint)
    {
        Debug.Log(checkpoint.transform.name);
    }

}
