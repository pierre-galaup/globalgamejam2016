using UnityEngine;
using System.Collections;

public class UpdateGameManager : MonoBehaviour
{
    [SerializeField] private AudioSource ScenePlayerVoice;
    [SerializeField] private Action DefaultAction;

    public void Awake()
    {
        GameManager.Instance.PlayerAudioSource = this.ScenePlayerVoice;
        GameManager.Instance.CurentHabit = this.DefaultAction;
    }
}
