
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    public void UpdateScore(int score)
    {
        ScoreText.text = score.ToString();
    }
}