using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airPatrol : MonoBehaviour
{
    public Transform point_1;
    public Transform point_2;
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(point_1.position.x, point_1.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, point_1.position, speed * Time.deltaTime);
        if(transform.position == point_1.position)
        {
            Transform t = point_1;
            point_1 = point_2;
            point_2 = t;
        }
    }
}
