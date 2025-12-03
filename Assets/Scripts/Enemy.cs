using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    private Vector3 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = (target.transform.position - transform.position).normalized;
        transform.position = transform.position + direction * Time.deltaTime;
    }
}
