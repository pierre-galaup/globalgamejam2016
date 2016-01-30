using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject CreditsCanvas;

    [SerializeField] private string FirstScene;

    public void Play()
    {
        SceneManager.LoadScene(this.FirstScene);
    }

    public void Credits()
    {
        MainMenuCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    public void Back()
    {
        MainMenuCanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
    }
}
