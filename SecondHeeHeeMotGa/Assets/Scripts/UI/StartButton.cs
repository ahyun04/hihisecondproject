using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject DialogueSkipContoll;
    public GameObject AcharacterImage;
    public Text AdialogueText;
    public Text AnameText;

    void Update()
    {

    }
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
        SceneManager.LoadScene("JiHwanCG");
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
        SceneManager.LoadScene("Merge_Test");
    }
    public void OnClick2DialogueSkip()
    {
        DialogueSkipContoll.GetComponent<DialogSystem>().currentDialogIndex = 119;
        //AdialogueText.text = "(¾îÂ¼Áö)";
        //AnameText.text = "";
        //AcharacterImage.SetActive(false);
    }
    public void OnClickM1DialogueSkip()
    {
        DialogueSkipContoll.GetComponent<DialogSystem>().currentDialogIndex = 1;
    }
    public void OnClickM1Select()
    {
        SceneManager.LoadScene("Mmerge_1");
    }
}
