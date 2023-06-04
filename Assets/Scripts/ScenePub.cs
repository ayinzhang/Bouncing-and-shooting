using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
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

    public void Set()
    {
        if (setting.GetComponent<Image>().sprite == play)
        {
            setting.transform.localScale = new Vector3(1, 1, 1);
            setting.GetComponent<Image>().sprite = pause;
        }
        else
        {
            setting.transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);
            setting.GetComponent<Image>().sprite = play;
        }
    }
    #endregion
    Sprite play;
    Sprite pause;
    GameObject setting;
    void Start()
    {
        play = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Play.png");
        pause = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/Pause.png");
        setting = GameObject.Find("Canvas/Setting");
    }
}
