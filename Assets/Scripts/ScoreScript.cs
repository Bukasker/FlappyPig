using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    static public float score;
    void Start()
    {
        scoreText = GetComponent<Text>();
        StartCoroutine(ScoreCount());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text ="Score : " + score;
    }
    IEnumerator ScoreCount()
    {
        Debug.Log(CanvansMenager.PlayGame);
        if (!PlayerController.gameOver && CanvansMenager.PlayGame)
        {
            yield return new WaitForSeconds(2f);
            score += 10;
            ScoreScript2.score = score;
            if (!PlayerController.gameOver)
            {
                StartCoroutine(ScoreCount());
            }
        }
    }
}
