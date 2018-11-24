using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingController : MonoBehaviour {

    [SerializeField] Text ranking;
    private int[] sort = new int[6];
    private int tmp = 0;

    // Use this for initialization
    void Start () {
        ranking.GetComponent<Text>().text = "";
        saveRanking();
        printRanking();
        UIController.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void printRanking()
    {
        for (int i = 0; i < 6; i++)
        {
            sort[i] = PlayerPrefs.GetInt(""+i,0);
            Debug.Log(sort[i]);
        }
        for (int start = 1; start < sort.Length; start++)
        {
            for (int end = sort.Length - 1; end >= start; end--)
            {
                if (sort[end - 1] <= sort[end])
                {
                    tmp = sort[end - 1];
                    sort[end - 1] = sort[end];
                    sort[end] = tmp;
                }
            }
        }
        bool f = true;
        for (int i = 0; i < 5; i++)
        {
            if (f && UIController.score == sort[i])
            {
                ranking.GetComponent<Text>().text += "<color=red>" + (i + 1) + "位： Score  " + sort[i].ToString("D4") + "</color>\n";
                PlayerPrefs.SetInt("" + i, sort[i]);
                f = false;

            }
            else
            {
                ranking.GetComponent<Text>().text += i + 1 + "位： Score  " + sort[i].ToString("D4") + "\n";
                PlayerPrefs.SetInt("" + i, sort[i]);

            }
        }
        PlayerPrefs.Save();
    }

    void saveRanking()
    {
        PlayerPrefs.SetInt("5", UIController.score);
        PlayerPrefs.Save();
    }
}
