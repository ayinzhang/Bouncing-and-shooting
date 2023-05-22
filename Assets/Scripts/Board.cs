using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    FloatingJoystick joystick;

    void Start()
    {
        joystick = GameObject.Find("Board Joystick").GetComponent<FloatingJoystick>();
    }

    void Update()
    {
        transform.position += new Vector3(0.1f * joystick.Horizontal, 0, 0);

        if (transform.position.x < -9.2) transform.position = new Vector2(-9.2f, -3.5f);
        else if (transform.position.x > 9.2) transform.position = new Vector2(9.2f, -3.5f);
    }
}
