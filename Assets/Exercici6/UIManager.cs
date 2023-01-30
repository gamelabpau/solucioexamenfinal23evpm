using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnable()
    {
        GetDamage.DamageReceived += OnPlayerDamageReceived;
    }

    private void OnDisable()
    {
        GetDamage.DamageReceived += OnPlayerDamageReceived;
    }

    private void OnPlayerDamageReceived(float damage)
    {
        Debug.Log("[UIManager] Player receives damage: " + damage);
    }
}
