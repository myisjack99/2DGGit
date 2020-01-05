using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;

    private void Awake()
    {
        
    }

    public void OpenMenu()
    {
        if (!GameManager.pauseEnable)   //if running
        {
            GameManager.pauseEnable = true;
            Time.timeScale = 0;
            //Cursor.visible = true;
            menu.SetActive(true);
        }
        else    //if paused
        {
            GameManager.pauseEnable = false;
            Time.timeScale = 1;
            //Cursor.visible = false;
            menu.SetActive(false);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
