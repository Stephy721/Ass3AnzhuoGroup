using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{


    public Button StartButton;


    // Use this for initialization
    void Start()
    {
        StartButton.onClick.AddListener(StartButtonListener);         
         
    }


    void StartButtonListener()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game02Scene");
    }

    void QuitButtonClickListener()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
