using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        GameObject goal = GameObject.Find("Goal");
        goal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
