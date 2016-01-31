using System;
using UnityEngine;
using System.Collections.Generic;

public class Opportunity : Action
{
    [SerializeField]
    protected MonoBehaviour OnTrigger;

    public override void Execute()
    {
        GameManager.Instance.PlayerAudioSource.Stop();
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        this.OnTrigger.enabled = true;
    }
}
