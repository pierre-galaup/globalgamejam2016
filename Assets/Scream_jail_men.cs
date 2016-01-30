using UnityEngine;
using System.Collections;

public class Scream_jail_men : MonoBehaviour {

    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
