using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{   public Movement fish_moving;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rubbish"))
        {
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("BakaFish")){
            fish_moving.enabled=false;
        }
    }
}
