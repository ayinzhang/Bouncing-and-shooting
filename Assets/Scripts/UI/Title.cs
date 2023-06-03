using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    float x, y, dx, dy;

    IEnumerator ScaleAndRotate()
    {
        while (true)
        {
            x = Random.Range(0.85f, 1.15f); y = Random.Range(0.85f, 1.15f);
            dx = x - transform.localScale.x; dy = y - transform.localScale.y;
            for (int i = 0; i < 100; i++)
            {
                transform.localScale += new Vector3(dx / 100, dy / 100, 0);
                transform.Rotate(0, 0, 0.08f); yield return new WaitForSecondsRealtime(0.025f);
            }
            x = Random.Range(0.85f, 1.15f); y = Random.Range(0.85f, 1.15f);
            dx = x - transform.localScale.x; dy = y - transform.localScale.y;
            for (int i = 0; i < 200; i++)
            {
                transform.localScale += new Vector3(dx / 200, dy / 200, 0);
                transform.Rotate(0, 0, -0.08f); yield return new WaitForSecondsRealtime(0.025f);
            }
            x = Random.Range(0.85f, 1.15f); y = Random.Range(0.85f, 1.15f);
            dx = x - transform.localScale.x; dy = y - transform.localScale.y;
            for (int i = 0; i < 100; i++)
            {
                transform.localScale += new Vector3(dx / 100, dy / 100, 0);
                transform.Rotate(0, 0, 0.08f); yield return new WaitForSecondsRealtime(0.025f);
            }
        }
    }

    void Start()
    {
        StartCoroutine("ScaleAndRotate");
    }
}