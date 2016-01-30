using System;
using UnityEngine;
using System.Collections.Generic;

public class Opportunity : Action
{
    public override void Execute()
    {
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        this.OnTrigger.enabled = true;
    }
}
