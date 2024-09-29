using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFood : MonoBehaviour
{
    public GameObject[] foods;
    void Start()
    {
        GameObject rndFood = foods[Random.Range(0, foods.Length)];
    }
}
