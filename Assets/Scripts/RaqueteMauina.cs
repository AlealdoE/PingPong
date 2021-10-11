using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteMauina : MonoBehaviour
{
    public Transform ball;
    public float velocidade;
    private Rigidbody2D rbcomp;
    // Start is called before the first frame update
    void Start()
    {   
        rbcomp = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbcomp.velocity = new Vector2(0,(ball.transform.position.y - transform.position.y)*velocidade);
    }
}
