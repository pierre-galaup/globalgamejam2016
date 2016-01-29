using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    
    private static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                var notificationObject = new GameObject("GameManager");
                _instance = (GameManager)notificationObject.AddComponent(typeof(GameManager));
            }
            return _instance;
        }
    }
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
