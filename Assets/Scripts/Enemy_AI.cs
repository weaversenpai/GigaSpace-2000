using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    //Speed multiplier
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //How fast we turn
        float RotationSpeed = 10;
        //Rotation offset in degrees
        float offset = 90;
        //How fast we go
        float step = speed * Time.deltaTime;

        //Let's find the target using tags
        Vector3 PlayerLocation = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector3 dir = PlayerLocation - transform.position;
        
        //Rotate toward our direction and offset our rotation
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, RotationSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, PlayerLocation, step);

    }

}
