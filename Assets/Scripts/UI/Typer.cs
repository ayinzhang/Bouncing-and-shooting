using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Typer : MonoBehaviour
{
    Text character;
    AudioSource audioSource;
    GameObject obj;
    public string[] words;
    public float interval = 0.15f;

    IEnumerator StartTyper()
    {
        foreach (string word in words)
        { 
            audioSource.Play();
            for (int i = 0; i <= word.Length; i++) 
            { 
                character.text = word.Substring(0, i); 
                yield return new WaitForSecondsRealtime(interval); 
            }
            audioSource.Stop();
            yield return new WaitForSecondsRealtime(1.5f); 
        }
        gameObject.active = false;
        obj.active = true;
    }

    void Start()
    {
        obj = GameObject.Find("GameObject");
        obj.active = false;
        character = gameObject.GetComponent<Text>();
        audioSource = GameObject.Find("EffectPlayer").GetComponent<AudioSource>();
        StartCoroutine("StartTyper");
    }
}
