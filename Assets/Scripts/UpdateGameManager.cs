using UnityEngine;
using System.Collections;

public class UpdateGameManager : MonoBehaviour
{
    [SerializeField] private AudioSource ScenePlayerVoice;

    public void Awake()
    {
        GameManager.Instance.PlayerAudioSource = this.ScenePlayerVoice;
    }
}
