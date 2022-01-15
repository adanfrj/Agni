using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveScript : MonoBehaviour
{
    public GameObject objToActivate;
    AudioSource attachedAudioSource;
     
    void Start () 
    {
        attachedAudioSource = objToActivate.GetComponent<AudioSource>();
    }
 
    void Update () 
    {
         // on left mouse button (by default)
         if (Input.GetButtonDown("Fire1"))
         {
             // check if object is active and if audio is playing
             if (objToActivate.activeSelf && !attachedAudioSource.isPlaying)
             {
                 // deactivate object
                 objToActivate.SetActive(false);
             }
             // check if object is deactivated
             else if (!objToActivate.activeSelf)
             {
                 // activate object if it was deactivated
                 objToActivate.SetActive(true);
                 // make sure audiosource isnt playing already for some reason
                 if (!attachedAudioSource.isPlaying)
                 {
                     // make sure audio is not looping
                     attachedAudioSource.loop = false;
                     // play audiosource
                     attachedAudioSource.Play();
                 }                
             }
         }        
     }
}
