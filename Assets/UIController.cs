using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    int score = 0;
    GameObject scoreText;

    public void AddScore()
    {
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}