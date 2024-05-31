using UnityEngine;

public class UiButtonMinus : MonoBehaviour
{

    public void BTN_Minus()
    {
        EventManager.OnRemoveScore.Invoke();
    }

}
