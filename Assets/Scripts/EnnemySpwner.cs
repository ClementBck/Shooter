using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpwner : MonoBehaviour
{
    public GameObject ennemyToSpawn;
    public int timerA = 0;
    public float speed = 1f;
    public Transform limitL;
    public Transform limitR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerA++;
        if (timerA >= 30)
        {
            timerA = 0;
            int random1 = Random.Range(-5, 6);
            if (random1 <= 0)
            {
                transform.position += Vector3.left * speed;
            }
            if (random1 >= 1)
            {
                transform.position += Vector3.right * speed;
            }
            print(random1);
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
}
