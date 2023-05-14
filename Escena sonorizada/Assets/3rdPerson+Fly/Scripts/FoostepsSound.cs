using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FoostepsSound : MonoBehaviour
{
    public AudioClip[] foostepsOnGrass;
    public AudioClip[] foostepsOnStone;

    public AudioSource audioSource;

    public string material;

    int random1;
    int random2;


    void PlayFoostepSound()
    {
        random1 = Random.Range(0, foostepsOnGrass.Length);
        random2 = Random.Range(0, foostepsOnStone.Length);

        if (material == "Grass")
        {
            audioSource.volume = Random.Range(0.8f, 1);
            audioSource.pitch = Random.Range(0.7f, 1);
            audioSource.PlayOneShot(foostepsOnGrass[random1]);
        }

        if (material == "Stone")
        {
            audioSource.volume = Random.Range(0.1f,0.25f);
            audioSource.pitch = Random.Range(0.7f,0.9f);
            audioSource.PlayOneShot(foostepsOnStone[random2]);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        tag = collision.gameObject.tag;
        if ( tag == "Grass" || tag == "Stone")
        {
            material = tag;
            Console.WriteLine(material);
        }
    }
}
