using UnityEngine;
using System.Collections;

public class AudioTriggerHandler : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour ScriptToRun;
    [SerializeField]
    private AudioClip Clip;

    [SerializeField] private AudioSource audioSource;

    [SerializeField]
    private bool IsUnique = true;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        if (this.Clip != null)
        {
            this.audioSource.PlayOneShot(this.Clip);
        }
        if (this.ScriptToRun != null)
            this.ScriptToRun.enabled = true;
        if (this.IsUnique)
            this.gameObject.SetActive(false);
    }
}
