using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{

    public TextMeshProUGUI text;

    private int score = 0;

    private void AddScore(int value)
    {
        score += value;

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        text.SetText(score.ToString());
    }

    void OnEnable()
    {
        EventManager.OnAddScore += AddScore;
    }

    void OnDisable()
    {
        EventManager.OnAddScore -= AddScore;
    }

}
