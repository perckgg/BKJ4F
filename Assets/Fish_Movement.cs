using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Movement : MonoBehaviour

{   
    private Vector2 screenBounds;
    public float speed_fish = 10.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed_fish, 0);
        screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>screenBounds.x*1.3){
            Destroy(this.gameObject);
        }
        
    }
    
}
