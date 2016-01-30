using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private string NextSceneName;

	// Use this for initialization
	void Start()
    {
	    SceneManager.LoadScene(this.NextSceneName);
    }
	
}
