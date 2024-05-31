using UnityEngine;

public class UiButtonPlus : MonoBehaviour
{
    
    public void BTN_Plus()
    {
        EventManager.OnAddScore.Invoke();
    }

}
