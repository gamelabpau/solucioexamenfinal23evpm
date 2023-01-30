using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Vertical");

        Vector3 direction = Vector3.forward * h + Vector3.right * v;
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
