using UnityEngine;
using System.Collections;

public class Haunted_Room : MonoBehaviour
{
    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
