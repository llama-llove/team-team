using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mouse : MonoBehaviour
{
    public Vector3 mouseposition;
    public int speed;
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

        mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.position = Camera.main.ScreenToWorldPoint(mouseposition);
    }
}
