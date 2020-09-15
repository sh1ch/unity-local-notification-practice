using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GotoScene2()
    {
        SceneManager.LoadSceneAsync("Scene2");
    }

    public void GotoScene3()
    {
        SceneManager.LoadSceneAsync("Scene3");
    }

    public void GotoSampleScene()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
}
