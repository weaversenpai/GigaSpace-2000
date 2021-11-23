using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// This script moves the attached object along the Y-axis with the defined speed
public class DirectMoving : MonoBehaviour
{

    public float maxSpeed = 5f;

    private void Update()
    {
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime);

        pos += transform.rotation * velocity;

        transform.position = pos;
    }
}