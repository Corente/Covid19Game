using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menus : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://soutenir.msf.fr/b/mon-don");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
