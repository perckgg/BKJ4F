using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckCollision : MonoBehaviour
{   public Movement fish_moving;
    public GameManager Manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rubbish"))
        {
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("BakaFish")){
            fish_moving.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
