using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public delegate void DamageDelegate(float damage);
    public static event DamageDelegate DamageReceived;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            DamageReceived?.Invoke(100f);
        }
        else if (collision.gameObject.CompareTag("Meteorit"))
        {
            DamageReceived?.Invoke(30f);
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            DamageReceived?.Invoke(10f);
        }
        else if (collision.gameObject.CompareTag("BigBoss"))
        {
            DamageReceived?.Invoke(50f);
        }
    }
}
