using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for behavior of ground enemy

public class GroundPatrol : MonoBehaviour
{
    public float speed = 3f;
    public bool moveLeft = true;
    public Transform groundDetect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the move to left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, 1f);  
        if(groundInfo.collider == false)
        {
            if(moveLeft == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                moveLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveLeft = true;
            }
        }
    }
}
