using UnityEngine;
using System.Collections;

public class Scream_women : MonoBehaviour
{

    [SerializeField]
    private AudioSource ScreamAudioSource;

	void OnTriggerEnter (Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
