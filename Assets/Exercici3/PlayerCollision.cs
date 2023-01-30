using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private List<AudioClip> audioClips;

    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arbre"))
        {
            audioSource.PlayOneShot(audioClips[0]);
        }
        else if (collision.gameObject.CompareTag("Roca"))
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
}
