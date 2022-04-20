using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController04 : MonoBehaviour
{
    public static GameController04 Instance = null;
    public int Coinscore = 0;
    public Text Cointxt_score;

    public GameObject WinPanel;

    public AudioSource GetSound;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }



    public void SetCoin()
    {
        GetSound.Play();
        Coinscore += 1;

        Cointxt_score.text = Coinscore.ToString();

        if (Coinscore >= 5)
        {

            WinPanel.SetActive(true);

        }
    }

    public void GameController04Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameController04Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
