using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airPatrol : MonoBehaviour
{
    public Transform point_1;
    public Transform point_2;
    public float speed = 2f;
    public float waitTime = 3f;
    private bool canGo = true;

    // Start is called before the first frame update
    void Start()
    {
        //set start position
        gameObject.transform.position = new Vector3(point_1.position.x, point_1.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(canGo == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, point_1.position, speed * Time.deltaTime);
            if (transform.position == point_1.position)
            {
                //to change point_1 to point_2
                Transform t = point_1;
                point_1 = point_2;
                point_2 = t;
                canGo = false;
                StartCoroutine(Waiting());
            }
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waitTime);
        if (transform.rotation.y == 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
            transform.eulerAngles = new Vector3(0, 0, 0);
        //transform.eulerAngles = new Vector3(0, transform.rotation.y + 180, 0);
        canGo = true;
    }



}
