using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePub : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        SceneManager.LoadScene(Data.nowIndex);
    }

    public void Next()
    {
        SceneManager.LoadScene(++Data.nowIndex);
    }
}
