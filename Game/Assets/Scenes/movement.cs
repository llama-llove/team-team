using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D self;
    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            self.MovePosition(new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y));
        }
        if (Input.GetKey("d"))
        {
            self.MovePosition(new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y));
        }

    }
}
