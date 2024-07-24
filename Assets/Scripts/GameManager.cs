using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
