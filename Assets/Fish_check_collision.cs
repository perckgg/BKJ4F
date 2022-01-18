using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_check_collision : MonoBehaviour

{   
    public Fish_Movement move;
         private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rubbish"))
        {
           
            move.speed_fish=0;
            move.enabled=false;
        }
    }
}
