using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class Habit : MonoBehaviour
{
    [SerializeField]
    private AudioClip Speech;

    [SerializeField]
    private MonoBehaviour OnTrigger;

    [SerializeField] private Habit ExpectedHabit;

    internal void ExecuteHabit()
    {
        if (GameManager.Instance.CurentHabit != this.ExpectedHabit)
            return;
        GameManager.Instance.CurentHabit = this;
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        this.OnTrigger.enabled = true;
    }

}
