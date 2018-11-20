using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

    public void OpenInfo(){
        Debug.Log("Information");
        GameObject.Find("Canvas").transform.Find("Panel_Info").gameObject.SetActive(true);
    }

    public void OpenSet()
    {
        Debug.Log("Settings");
        GameObject.Find("Canvas").transform.Find("Panel_Set").gameObject.SetActive(true);
    }

    public void Close()
    {
        Debug.Log("Close");
        GameObject.Find("Canvas").transform.Find("Panel_Info").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Panel_Set").gameObject.SetActive(false);
    }

    public void toStartMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
