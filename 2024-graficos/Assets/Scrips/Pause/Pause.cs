using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPause;
    [SerializeField] GameObject panel;
    private void Awake()
    {
        PauseGameplay();
        isPause = true;
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPause == true)
            {
                ResumeGameplay();
                Debug.Log("isPause == true ");

            }
            else {
                Debug.Log("isPause != true ");

                PauseGameplay();
            }
        }
    }

    public void PauseGameplay()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        isPause = true;
    }
    public void ResumeGameplay()
    {
        Time.timeScale = 1;
        isPause = false;
    }
}
