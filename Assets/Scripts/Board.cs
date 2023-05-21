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

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.tag == "Boundary")
        //    transform.position -= new Vector3(0.1f * joystick.Horizontal, 0, 0);
    }

    void Update()
    {
        transform.position += new Vector3(0.1f * joystick.Horizontal, 0, 0);
    }
}
