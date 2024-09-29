using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obj;
    public GameObject spawnPoint;
    public GameObject[] spawnFood;
    public float repeatTime;
    public float xMax;
    public float xMin;
    private float xRnd;
    private void Start()
    {
        InvokeRepeating("Spawn", 1f, repeatTime);
    }

    void Spawn()
    {
        GameObject rndFood = spawnFood[Random.Range(0, spawnFood.Length)];

        xRnd = Random.Range(xMin, xMax);

        Instantiate(rndFood, new Vector3(xRnd, 4, 0), Quaternion.identity);
    }
}

