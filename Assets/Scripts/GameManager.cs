using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject goal;
    GameObject menu;
    public static bool pauseEnable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        goal = GameObject.Find("Goal");
        goal.SetActive(false);
        menu = GameObject.Find("MenuBackground");
        menu.SetActive(false);

        pauseEnable = false;
        Time.timeScale = 1;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!pauseEnable)
            {
                pauseEnable = true;
                Time.timeScale = 0;
                //Cursor.visible = true;
                menu.SetActive(true);
            }
            else
            {
                pauseEnable = false;
                Time.timeScale = 1;
                //Cursor.visible = false;
                menu.SetActive(false);
            }
        }
    }

}
