using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public Vector3 direction;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction.normalized * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthComponent HC = collision.GetComponent<HealthComponent>();
        if (HC != null) {
            collision.GetComponent<HealthComponent>().takesDamage(1);
            Destroy(gameObject);
        }

    }



    
}
