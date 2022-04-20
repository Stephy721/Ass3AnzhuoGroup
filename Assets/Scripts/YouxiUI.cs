using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YouxiUI : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    public void sceneLoad(string s)
    {	
        SceneManager.LoadScene(s);
    }
    public void quit()
    {
        SceneManager.LoadScene(0);
    }

    public void pause()
    {

        Time.timeScale = 0;
    }

    public void unpause()
    {

        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            pause();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            unpause();
        }

    }
}
