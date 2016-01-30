using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class Habit : Action
{
    [SerializeField] private Habit ExpectedHabit;

    public override void Execute()
    {
        if (GameManager.Instance.CurentHabit != this.ExpectedHabit)
            return;
        GameManager.Instance.CurentHabit = this;
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        this.OnTrigger.enabled = true;
    }

}
