using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class resultScoreController : MonoBehaviour
{

    GameObject resultScoreText;

    // Use this for initialization
    void Start()
    {
        this.resultScoreText = GameObject.Find("resultScoreText");
        resultScoreText.GetComponent<Text>().text = "Score:" + UIController.score.ToString("D4");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
