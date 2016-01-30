using UnityEngine;

public class Habit : Action
{
    [SerializeField] private Habit ExpectedPreviousHabit;

    public override void Execute()
    {
        if (GameManager.Instance.CurentHabit != this.ExpectedPreviousHabit)
            return;
        GameManager.Instance.CurentHabit = this;
        GameManager.Instance.PlayerAudioSource.PlayOneShot(this.Speech);
        if (this.OnTrigger != null)
            this.OnTrigger.enabled = true;
    }

}
