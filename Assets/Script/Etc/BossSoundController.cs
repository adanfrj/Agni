using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSoundController : MonoBehaviour
{
    public AudioClip attack;
    private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void Attack()
    {
        audioPlayer.PlayOneShot(attack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
