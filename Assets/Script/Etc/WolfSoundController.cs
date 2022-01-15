using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfSoundController : MonoBehaviour
{
    public AudioClip attack, walking;
    private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void AttackWolf()
    {
        audioPlayer.PlayOneShot(attack);
    }

    public void WalkingWolf()
    {
        audioPlayer.PlayOneShot(attack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
