using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGUI : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = 0;
    }

    public void sceneLoad(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }


    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }




}
