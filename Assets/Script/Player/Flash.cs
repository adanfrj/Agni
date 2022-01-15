using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public bool isOn = false;
    public GameObject flash;
 
    public int ammo = 0;
    private CharacterSoundController sound;


    void Start()
    {
        sound = GetComponent<CharacterSoundController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flash"))
        {
            if (ammo < 3)
            {
                isOn = !isOn;
                flash.SetActive(isOn);
                if (isOn == true)
                {
                    ammo = ammo + 1;
                }
                sound.Flashing();
            }
            else
            {
                flash.SetActive(false);
                Debug.Log("Run out of ammo");
                sound.Flashing();
            }
        }
    }

}
