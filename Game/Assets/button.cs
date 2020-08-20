using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public int speed;
    public Rigidbody2D self;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("die", 1);
            while (true)
            {
                self.MovePosition(new Vector2(self.position.x+speed*Time.deltaTime,self.position.y));
            }
        }
    }
    private void die()
    {
        Destroy(self.gameObject);
    }

}
