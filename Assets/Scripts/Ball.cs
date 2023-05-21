using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody;

    void Start()
    {
        print("start");
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.velocity = rigidbody.velocity.magnitude * Vector2.Reflect(rigidbody.velocity, collision.GetContact(0).normal).normalized;
        print(rigidbody.velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
