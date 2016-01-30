using UnityEngine;
using System.Collections;

public class Scream_men_jail2 : MonoBehaviour {

    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
