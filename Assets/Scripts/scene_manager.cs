using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }

    public void SceneA()
    {
        SceneManager.LoadScene("SceneA");
    }

    public void SceneB()
    {
        SceneManager.LoadScene("SceneB");
    }

    public void MRTK_Example()
    {
        SceneManager.LoadScene("HandInteractionExamples");
    }

}
