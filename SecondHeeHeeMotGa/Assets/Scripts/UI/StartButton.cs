using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject DialogueSkipContoll;
    public void OnClickStart()
    {
        SceneManager.LoadScene("Dialogue_Test");
    }
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Á¾·á");
    }
    public void OnClickGallery()
    {
        SceneManager.LoadScene("Gallery");
    }
    public void OnClickUnkonwnGallery()
    {
        SceneManager.LoadScene("UnknownCG");
    }
    public void OnClickMinHyukGallery()
    {
        SceneManager.LoadScene("MinhyukCG");
    }
    public void OnClckHyunWooGallery()
    {
        SceneManager.LoadScene("HyunWooCG");
    }
    public void OnClickJiHwanGallery()
    {
        SceneManager.LoadScene("JiHwanGallery");
    }
    public void OnClickGalleryExit()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnClickCGExit()
    {
        SceneManager.LoadScene("Gallery");
    }
    public void OnClickADialogueSkip()
    {
        DialogueSkipContoll.GetComponent<DialogSystem>().currentDialogIndex = 47;
    }
}
