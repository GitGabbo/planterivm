using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public GameObject panel;

    public void SceneExplore(){
        SceneManager.LoadScene("Explore");
    }

    public void SceneLectures()
    {
        SceneManager.LoadScene("Lectures");
    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("Il gioco si sta chiudendo");
    }


    public void ToggleInstructionsPanel()
    {
        panel.SetActive(!panel.activeInHierarchy);
    }
}
