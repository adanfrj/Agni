using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSoundController : MonoBehaviour
{
    public AudioClip attack, flapping;
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

    public void Flapping()
    {
        audioPlayer.PlayOneShot(flapping);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
