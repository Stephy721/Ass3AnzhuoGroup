using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public float rotspeed;

    private CharacterController PlayerMove;
    private float gravity = 3.0f;

    public Text Trashtext;         
    private int Trashscore = 0;

    public AudioSource GetSound;

    public Button SoundBtn;
    public bool IsSound = false;
    public GameObject SoundAU;

    // Use this for initialization
    void Start ()
    {
        PlayerMove = gameObject.GetComponent<CharacterController>();

        SoundBtn.onClick.AddListener(SoundBtnLis);
    }

    // Update is called once per frame
    void Update () {

        float x = 0, y = 0, z = 0;
  
        y -= gravity * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            z += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }

        PlayerMove.Move(transform.TransformDirection(new Vector3(x, y, z)));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Destroy(other.gameObject);
            GetSound.Play();
            Trashscore += 100;
            Trashtext.text = Trashscore.ToString();

            if (Trashscore == 1000)
            {
                SceneManager.LoadScene(2);
            }
        }

        if (other.tag == "Fish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void SoundBtnLis()
    {

        if (IsSound == false)
        {
            SoundAU.SetActive(true);
            IsSound = true;
        }
        else
        {
            SoundAU.SetActive(false);
            IsSound = false;
        }

    }

}
