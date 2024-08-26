using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void ActivatePanel(GameObject panel)
    {
        panel.SetActive(true);    
    }

    public void DeactivatePanel(GameObject panel)
    {
        panel.SetActive(false);

    }
}
