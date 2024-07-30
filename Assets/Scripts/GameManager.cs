using UnityEngine;
using System.IO;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    string playerName;
    string highscoreString;
    int highscore;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighscoreData();
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int Highscore;
        public string HighscoreString;
    }

    public void SaveHighscoreData()
    {
        SaveData data = new SaveData();
        data.PlayerName = playerName;
        data.Highscore = highscore;
        data.HighscoreString = highscoreString;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "highscores.json", json);
    }
    public void LoadHighscoreData()
    {
        string path = Application.persistentDataPath + "highscores.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerName = data.PlayerName;
            highscore = data.Highscore;
            highscoreString = data.HighscoreString;
        }
    }
    public void SetName(string name) => playerName = name;
    public string GetName() { return playerName; }
    public void SetHighScore(string scoreString, int score)
    {
        highscoreString = scoreString;
        highscore = score;
    }
    public int GetHighScore() { return highscore; }
    public string GetHighScoreString() { return highscoreString; }
}
