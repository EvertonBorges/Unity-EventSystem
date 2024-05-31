using UnityEngine;

public class UiButtonPlus : MonoBehaviour
{

    public UiScore uiScore;
    
    public void BTN_Plus()
    {
        uiScore.AddScore();
    }

}
