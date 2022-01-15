using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool sceneFreeze = false;
    
    // Update is called once per frame
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Gameplay");
            Time.timeScale = 1f;
            sceneFreeze = false;
            
        }

    }
}
