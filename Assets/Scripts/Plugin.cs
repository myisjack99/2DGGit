﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plugin : MonoBehaviour
{
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Plug"))
            goal.SetActive(true);
        else if (collision.tag.Equals("Exit"))
            Application.Quit();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Plug"))
            goal.SetActive(false);
    }
}
