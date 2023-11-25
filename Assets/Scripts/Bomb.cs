using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public Transform myTransform;
    public GameObject supernova;
    public float scaling = 0.02f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.velocity = Vector3.up * speed;
    }

    private void Update()
    {
        myTransform.localScale += new Vector3(scaling, scaling, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        scaling += 0.02f;
        Invoke("DestroyBomb", 0.4f);
    }

    public void DestroyBomb()
    {
        Instantiate(supernova, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}