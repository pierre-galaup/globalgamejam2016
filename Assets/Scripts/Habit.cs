using System;
using System.Collections.Generic;
using UnityEngine;

public class Habit : Action
{
    [SerializeField]
    private List<Action> ExpectedPreviousActions = new List<Action>();
    [SerializeField]
    private List<MonoBehaviour> PreviousActionsScripts = new List<MonoBehaviour>();

    private Dictionary<Action, MonoBehaviour> ExpectedPreviousActionsDict;

    public void Awake()
    {
        this.ExpectedPreviousActionsDict = new Dictionary<Action, MonoBehaviour>();
        if (this.ExpectedPreviousActions.Count != this.PreviousActionsScripts.Count)
            throw new NotSupportedException("ExpectedPreviousActions list and PreviousActionsScripts MUST have the exactly same number of elements");

        var i = 0;
        foreach (var key in this.ExpectedPreviousActions)
        {
            this.ExpectedPreviousActionsDict.Add(key, this.PreviousActionsScripts[i]);
            ++i;
        }
    }

    public override void Execute()
    {
        if (!this.ExpectedPreviousActionsDict.ContainsKey(GameManager.Instance.CurentHabit))
            return;
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        if (this.ExpectedPreviousActionsDict[GameManager.Instance.CurentHabit] != null)
            this.ExpectedPreviousActionsDict[GameManager.Instance.CurentHabit].enabled = true;
        GameManager.Instance.CurentHabit = this;
    }

    public override void Abort()
    {
        if (GameManager.Instance.PlayerAudioSource.isPlaying)
            GameManager.Instance.PlayerAudioSource.Stop();
    }
}
