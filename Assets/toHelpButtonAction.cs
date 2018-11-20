using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHelpButtonAction : MonoBehaviour {

    public void toHelpAction()
    {
        SceneManager.LoadScene("help");
    }
}
