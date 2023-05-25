using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePub : MonoBehaviour
{
    #region Botton Function
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(Data.nowIndex);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

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
    #endregion
}
