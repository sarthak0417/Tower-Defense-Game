using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class WolfSpwan : MonoBehaviour
{
    public GameObject WolfPrefab;
    public float spawnTime = 2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()//runs everyframe
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnEnemy();
        }
    }
    void SpawnEnemy()//create new wolf
    { 
        Instantiate(WolfPrefab, transform.position, Quaternion.identity);
        timer = spawnTime;
    }
}
