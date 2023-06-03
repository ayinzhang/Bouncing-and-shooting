using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text character;
    public AudioSource audioSource;
    public Transform frame;
    public string[] words;
    public float interval = 0.15f;

    IEnumerator StartTyper()
    {
        foreach (string word in words)
        { 
            audioSource.Play();
            for (int i = 0; i <= words.Length; i++) { character.text = word.Substring(0, i); frame.localScale = 1.1f * transform.localScale; yield return new WaitForSecondsRealtime(interval); }
            audioSource.Stop();
            yield return new WaitForSecondsRealtime(1.5f); character.text = ""; frame.localScale = new Vector3(0, 0, 0);
        }
    }

    void Start()
    {
        StartCoroutine("StartTyper");
    }
}
