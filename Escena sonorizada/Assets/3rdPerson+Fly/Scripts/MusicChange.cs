using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicChange : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;

    public AudioMixerSnapshot tensionSnapshot;

    public AudioMixerSnapshot climaxSnapshot;

    public float transitionTime = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tension")
            tensionSnapshot.TransitionTo(transitionTime);

        if (other.gameObject.tag == "Climax")
            climaxSnapshot.TransitionTo(transitionTime);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Climax")
            tensionSnapshot.TransitionTo(transitionTime);

        if (other.gameObject.tag == "Tension")
            baseSnapshot.TransitionTo(transitionTime);

    }
}
