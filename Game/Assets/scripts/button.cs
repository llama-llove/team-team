using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public int speed;
    public Rigidbody2D self;
    public Animator buttonanim;
    private void Start()
    {
        buttonanim = GameObject.Find("button_main").GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("die", 2);
            buttonanim.SetTrigger("pressed");
        }
    }

    private void die()
    {
        Destroy(self.gameObject);
    }

}
