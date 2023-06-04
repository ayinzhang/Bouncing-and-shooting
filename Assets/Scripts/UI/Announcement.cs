using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Announcement : MonoBehaviour
{
    IEnumerator Fade()
    {
        for (float i = 0; i <= 1; i += 0.01f) { GetComponent<Image>().color = new Color(i, i, i); yield return new WaitForSecondsRealtime(0.025f); }
        yield return new WaitForSecondsRealtime(1.5f);
        for (float i = 1; i >= 0; i -= 0.01f) { GetComponent<Image>().color = new Color(i, i, i); yield return new WaitForSecondsRealtime(0.025f); }
        Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine("Fade");
    }
}
