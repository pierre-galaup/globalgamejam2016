using System;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [NonSerialized]
    public Habit CurentHabit;

    [SerializeField]
    internal AudioSource PlayerAudioSource;
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        DontDestroyOnLoad(this);
    }
}
