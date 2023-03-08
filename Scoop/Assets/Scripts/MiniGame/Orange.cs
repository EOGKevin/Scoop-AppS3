using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    Main main;
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, 0.12f, 0f);

        if (tr.position.y < -7f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "basket")
        {
            Destroy(this.gameObject);
            main.ScoreAdd();
        }
    }
}
