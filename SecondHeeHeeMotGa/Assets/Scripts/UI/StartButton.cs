using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Dialogue_Test");
    }
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Á¾·á");
    }
}
