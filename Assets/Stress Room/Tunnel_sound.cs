using UnityEngine;
using System.Collections;

public class Tunnel_sound : MonoBehaviour {

    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
