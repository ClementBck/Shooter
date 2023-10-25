using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bomb;
    public ParticleSystem charging;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public int charge = 0;

    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, parent.position, parent.rotation);
            charge = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (charge < 100)
            {
                charging.Play();
                charge++;
                print(charge);
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (charge < 100)
            {
                charging.Stop();
                charge = 0;
                print(charge);
            }
            else
            {
                charging.Stop();
                charge = 100;
                Instantiate(bomb, parent.position, parent.rotation);
            }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bonus")
        {
            Destroy(gameObject);
        }
    }
}
