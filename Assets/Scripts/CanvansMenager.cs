using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvansMenager : MonoBehaviour
{
    public GameObject GameOverBackground;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject ResetetButton;
    public GameObject Menu;
    public GameObject SpawnMenager;
    [SerializeField]
    static public bool PlayGame;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameOver)
        {
            GameOverBackground.SetActive(true);
            Score2.SetActive(true);
            ResetetButton.SetActive(true);
            Score1.SetActive(false);
        }
        else
        {
            Score2.SetActive(false);
            Score1.SetActive(true);
        }
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerController.gameOver = false;
        ScoreScript.score = 0;
    }
    public void PlayScene()
    {
        Menu.SetActive(false);
        Score1.SetActive(true);
        PlayGame = true;
        Debug.Log(PlayGame);
        Player.SetActive(true);
    }
    public void QuitScene()
    {
        Application.Quit();
    }
}
