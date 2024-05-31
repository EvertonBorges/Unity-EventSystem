using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{

    public TextMeshProUGUI text;

    private int score = 0;

    private void AddScore()
    {
        score++;

        UpdateScoreText();
    }

    private void RemoveScore()
    {
        score--;

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        text.SetText(score.ToString());
    }

    void OnEnable()
    {
        EventManager.OnAddScore += AddScore;
        EventManager.OnRemoveScore += RemoveScore;
    }

    void OnDisable()
    {
        EventManager.OnAddScore -= AddScore;
        EventManager.OnRemoveScore -= RemoveScore;
    }

}
