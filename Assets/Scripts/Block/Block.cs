using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int num = 3;

    [HideInInspector]
    public int cnt;
    [HideInInspector]
    public SpriteRenderer renderer;

    void Start()
    {
        cnt = num;
        renderer = GetComponent<SpriteRenderer>();
    }
}
