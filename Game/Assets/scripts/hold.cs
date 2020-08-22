using UnityEngine;

public class hold : MonoBehaviour
{
    public Rigidbody2D self;
    public GameObject item;
    public bool isholding;

    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.GetComponent<Rigidbody2D>();
        isholding = false;
    }
    public bool mousedown()
    {
        if (Input.GetMouseButton(0))
        {
            return true;
        }
        return false;
    }
    // Update is called once per frame
    void Update()
    {

        if (mousedown())
        {
            isholding = true;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 1f);
            item = hit.collider.gameObject;
            item.transform.SetParent(transform, true);
            item.GetComponent<Rigidbody2D>().isKinematic = true;
            Debug.Log(item.name);
        }
        if(isholding&&!mousedown())
        {
            item.transform.SetParent(null,true);
            item.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
    void objecthold()
    {
        
        while (Input.GetMouseButton(0))
        {

        }


    }
}
