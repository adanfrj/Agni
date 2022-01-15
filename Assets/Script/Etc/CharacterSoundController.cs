using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump, hit,flash,landing;
    private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void Hit()
    {
        audioPlayer.PlayOneShot(hit);
    }

    public void Flashing()
    {
        audioPlayer.PlayOneShot(flash);
    }

    public void Landing()
    {
        audioPlayer.PlayOneShot(landing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
