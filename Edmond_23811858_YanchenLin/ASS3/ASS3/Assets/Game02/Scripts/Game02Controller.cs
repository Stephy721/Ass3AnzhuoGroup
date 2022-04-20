using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game02Controller : MonoBehaviour
{
    public static Game02Controller Instance = null;
    public int score = 0;
    public Text txt_score;

    public GameObject WinPanel;
    public GameObject LosePanel;

    public float TimeNum = 60;
    public Text TimeNumText;

    public bool IsRun = true;

    public AudioSource GetSound;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        if (IsRun == true)
        {
            if (TimeNum > 0)
            {
                TimeNum -= Time.deltaTime;
                TimeNumText.text = TimeNum.ToString("0");
            }
            else
            {
                WinPanel.SetActive(true);

                IsRun = false;
                Time.timeScale = 0;
            }
        }

    }

    public void SetCoin()
    {
        GetSound.Play();

        score += 1;

        txt_score.text = score.ToString();
    }

    public void Game02ControllerAgain()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Game02ControllerQuit()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }

    public void LosePanelLis()
    {
        Time.timeScale = 0;

        LosePanel.SetActive(true);

        IsRun = false;
    }

   public void QuitButtonClickListener()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
