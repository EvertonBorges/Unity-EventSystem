using UnityEngine;

public class UiButtonMinus : MonoBehaviour
{

    public UiScore uiScore;

    public void BTN_Minus()
    {
        uiScore.RemoveScore();
    }

}
