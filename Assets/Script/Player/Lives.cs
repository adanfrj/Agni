using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int playerLives;

    [SerializeField]
    private Image [] hearts;

    private void Start()
    {
        UpdateHealth();
    }

 
    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerLives)
            {
                hearts[i].color = Color.black;
            }
            else 
            {
                hearts[i].color = Color.red;
            }
        }
    }


}
