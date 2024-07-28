using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class ScenesManager : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitTheGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit;
#endif
    }
}
