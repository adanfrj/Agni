using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public bool isOn = false;
    public GameObject flash;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("FKey"))
        {
            isOn = !isOn;
            flash.SetActive(isOn);
        }
    }
}
