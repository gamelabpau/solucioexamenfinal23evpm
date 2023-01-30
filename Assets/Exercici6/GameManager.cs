using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
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
        Debug.Log("[GameManager] Player receives damage: " + damage);
    }
}
