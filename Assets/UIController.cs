using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    public static int score = 0;
    GameObject scoreText;

    public void AddScore()
    {
        score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    public static int getScore()
    {
        return score;
    }
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}