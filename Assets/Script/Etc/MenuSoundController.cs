using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundController : MonoBehaviour
{
    public AudioClip soundPause;
    private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PopupPause()
    {
        audioPlayer.PlayOneShot(soundPause);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
