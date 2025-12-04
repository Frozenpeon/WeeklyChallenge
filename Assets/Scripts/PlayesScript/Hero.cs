using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movements 
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //rb.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);

        transform.position = transform.position + (Vector3.right * horizontal + Vector3.up * vertical) * moveSpeed * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    private void Shoot()
    {
        Vector2 lBulletPos = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        lBulletPos.Normalize();
        GameObject lBullet = Instantiate(bullet, (Vector2)transform.position + lBulletPos, Quaternion.identity);
        lBullet.GetComponent<Bullet>().direction = lBulletPos.normalized;
    }
}
