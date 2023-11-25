using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public GameObject explosion;
    public Movement myPlayer;
    public GameObject coin;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ennemy")
        {
            myPlayer.score += 10;
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            int bonusRange = Random.Range(0, 20);
            if (bonusRange >= 16)
            {
                Instantiate(coin, transform.position, transform.rotation);
            }
        }
      }

}