using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger: " + collision);
        John player = collision.GetComponent<John>();

        if(player != null)
        {
            //player.Buff(gameObject);
            Debug.Log(gameObject);
            Destroy(gameObject);
        }
    }
}
