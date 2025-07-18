using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameUI : MonoBehaviour
{
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI ScoreText;

    public void ShowEndGame(int score)
    {
        gameObject.SetActive(true);

        int bestScore = PlayerPrefs.GetInt("BESTSCORE");

        if (score > bestScore)
        {
            HighscoreText.text = score.ToString();
            PlayerPrefs.SetInt("BESTSCORE", score);
        }
        else
        {
            HighscoreText.text = bestScore.ToString();
        }

        ScoreText.text = score.ToString();
    }

    public void RetryGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
