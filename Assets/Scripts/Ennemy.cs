using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public GameObject coin;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        int bonusRange = Random.Range(0, 20);
        if (bonusRange >= 14)
        {
            Instantiate(coin, transform.position, transform.rotation);
        }
        }
}
