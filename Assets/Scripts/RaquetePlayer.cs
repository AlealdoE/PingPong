using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RaquetePlayer : MonoBehaviour
{
    
    public float speed =10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       if(Input.GetKey("up")&& transform.position.y < 3.4f)
       {   
           transform.position = new Vector3(transform.position.x,transform.position.y + 0.1f, transform.position.z );
       }
        else if(Input.GetKey("down")&& transform.position.y > (-3.4f))
       {   
           transform.position = new Vector3(transform.position.x,transform.position.y - 0.1f, transform.position.z );
       }
    }
}