using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public InputField InputName;
    public Text highScoreText;

    void Start()
    {
        highScoreText.text = GameManager.Instance.GetHighScoreString();
    }
    public void SetCurPlayerName() => GameManager.Instance.SetName(InputName.text);
    public void StartNewGame(int sceneId) => ScenesManager.Instance.LoadScene(sceneId);
    public void ExitGame() => ScenesManager.Instance.QuitTheGame();
}
