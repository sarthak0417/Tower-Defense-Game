using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Start : MonoBehaviour
{
    public GameObject StartPrefab;
    public float coolDown = 2.5f;
    private float timer;

    // Start is called before the first frame update
    void Awake()
    {
    timer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(StartPrefab, transform.position, Quaternion.identity);
        }
    }
}