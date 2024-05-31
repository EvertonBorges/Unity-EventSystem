using UnityEngine;

public class UiButton : MonoBehaviour
{
    
    public void BTN_AddScore(int value)
    {
        EventManager.OnAddScore.Invoke(value);
    }

}
