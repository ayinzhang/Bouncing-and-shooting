using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody;
    SpriteRenderer renderer;
    int blockNum;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        blockNum = GameObject.Find("Block").transform.childCount;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if ((rigidbody.velocity * collision.GetContact(0).normal).magnitude <= 0)
            rigidbody.velocity = Vector2.Reflect(rigidbody.velocity, collision.GetContact(0).normal);

        if (collision.gameObject.tag == "Block")
        {
            var block = collision.gameObject.GetComponent<Block>();
            renderer.color = block.renderer.color;

            if (--block.cnt > 0) 
                block.renderer.color = new Color(block.renderer.color.r, block.renderer.color.g, block.renderer.color.b, (float)block.cnt / block.num);
            else
            {
                Destroy(collision.gameObject);
                if (--blockNum == 0)
                {
                    GameObject.Find("Canvas").transform.Find("Win").gameObject.active = true;
                    Time.timeScale = 0;
                }
            }
        }
    }

    void Update()
    {
        if(transform.position.y < -5)
        {
            GameObject.Find("Canvas").transform.Find("Fail").gameObject.active = true;
            Time.timeScale = 0;
        }
    }
}
