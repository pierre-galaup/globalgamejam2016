using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioTriggerHandler : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour ScriptToRun;
    [SerializeField]
    private AudioClip Clip;

    private AudioSource audioSource;

    public void Awake()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (this.Clip != null)
            this.audioSource.PlayOneShot(this.Clip);
        if (this.ScriptToRun != null)
            this.ScriptToRun.enabled = true;
    }
}
