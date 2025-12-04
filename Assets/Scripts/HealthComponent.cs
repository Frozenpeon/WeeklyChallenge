using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int actualHP = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takesDamage(int damage)
    {
        actualHP -= damage;
        if (actualHP <= 0 )
        {
            Destroy( gameObject );
        }
    }
}
