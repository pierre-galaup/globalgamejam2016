using UnityEngine;

public class ShutAlarmClockDown : MonoBehaviour
{
    [SerializeField] private AudioSource ToShutDown;

    public void Start()
    {
        this.ToShutDown.Stop();
    }
}
