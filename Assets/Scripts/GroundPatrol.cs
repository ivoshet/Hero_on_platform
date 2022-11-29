using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for behavior of ground enemy

public class GroundPatrol : MonoBehaviour
{
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the move to left
        transform.Translate(Vector2.left * speed * Time.deltaTime);   
    }
}
