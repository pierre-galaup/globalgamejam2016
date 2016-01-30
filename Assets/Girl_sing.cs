using UnityEngine;
using System.Collections;

public class Girl_sing : MonoBehaviour {


    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
