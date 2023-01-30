using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRayCast : MonoBehaviour
{
    public float range = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * range, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, range,
                LayerMask.GetMask("Player")))
        {
            Debug.Log(hitInfo.transform.name + " detected!");
        }
    }
}
