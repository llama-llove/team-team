using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mouse : MonoBehaviour
{
    public Vector3 mouseposition;
    public int speed;
    //public List<Rigidbody2D> armparts;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool mousedown()
    {
        if(Input.GetMouseButton(0))
        {
            return true;
        }
        return false; 
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0), Space.World);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0), Space.World);
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(new Vector3(0, speed * Time.deltaTime, 0), Space.World);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0), Space.World);
        //}
        mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //if (mousedown())
       // {
        //    foreach (Rigidbody2D part in armparts)
        //    {
        //        part.isKinematic = true;
        //    }
            transform.position = Camera.main.ScreenToWorldPoint(mouseposition);
        //}
        //else
        //{
        //    foreach (Rigidbody2D part in armparts)
        //    {
        //        part.isKinematic = false;
        //    }
        //}
    }
}
