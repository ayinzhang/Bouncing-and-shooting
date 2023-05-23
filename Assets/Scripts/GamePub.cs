using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePub : MonoBehaviour
{
    static Transform block;

    public static void Start()
    {
        block = GameObject.Find("Block").transform;
    }

    public static void Fail()
    {
        GameObject.Find("Canvas").transform.Find("Fail").gameObject.active = true;
        Time.timeScale = 0;
    }

    public static void Check()
    {
        if (block.childCount != 1) return;
        GameObject.Find("Canvas").transform.Find("Win").gameObject.active = true;
        Time.timeScale = 0;
    }
}
