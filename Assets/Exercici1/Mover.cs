using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    private void Start()
    {
        transform.LookAt(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) > 3.0f)
        {
            Vector3 moveDirection = target.position - transform.position;
            moveDirection.Normalize();
            // transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
           // transform.Translate(moveDirection * speed * Time.deltaTime);
           
            transform.position += moveDirection * speed * Time.deltaTime;
            // transform.localPosition += moveDirection * speed * Time.deltaTime;
        }
    }
}
