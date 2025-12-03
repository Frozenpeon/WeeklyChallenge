using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public GameObject HeroPrefab;
    public GameObject EnemyPrefab;

    private GameObject actualHero;

    void Start()
    {
        actualHero = Instantiate(HeroPrefab, new Vector2(0, 0), Quaternion.identity);
        Instantiate(EnemyPrefab, new Vector2(4, -4), Quaternion.identity).GetComponent<Enemy>().target = actualHero;
    }
}
