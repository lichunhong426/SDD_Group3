using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMonster : MonoBehaviour
{
    public GameObject[] monsters;
    public int xPos;
    public int zPos;
    public int monsterCount = 0;
    float nextSpawn = 0.0f;
    float spawnRate = 2f;

    private void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            xPos = Random.Range(10, 120);
            zPos = Random.Range(60, 190);
            foreach (GameObject monster in monsters)
            {
                Instantiate(monster, new Vector3(xPos, 0, zPos), Quaternion.identity);
            }
        }
    }

}
