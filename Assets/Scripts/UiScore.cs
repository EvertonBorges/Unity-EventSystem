using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{
    
    public TextMeshProUGUI text;

    private int score = 0;

    public void AddScore()
    {
        score++;

        UpdateScoreText();
    }

    public void RemoveScore()
    {
        score--;

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        text.SetText(score.ToString());
    }

}
