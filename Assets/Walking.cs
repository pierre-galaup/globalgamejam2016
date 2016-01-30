using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour
{
    [SerializeField]
    private AudioSource ScreamAudioSource;

    void OnTriggerEnter(Collider other)
    {
        this.ScreamAudioSource.Play();
    }
}
