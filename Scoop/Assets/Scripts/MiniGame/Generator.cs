using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    float timer = 1;
    public GameObject[] gm;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        else
        {
            int chance = Random.Range(1, 101);
            float pos_x = Random.Range(-4.0f, 4.0f);

            if (chance <= 22)
            {
                Instantiate(gm[1], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            else if (chance <= 44)
            {
                Instantiate(gm[2], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            else if (chance <= 67)
            {
                Instantiate(gm[3], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            else if (chance <= 90)
            {
                Instantiate(gm[4], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            else
            {
                Instantiate(gm[0], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            timer = 0.7f;
        }
    }
}
