using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnTargetFood : MonoBehaviour
{
    public GameObject[] foods;
    void Start()
    {
        int rndFood = Random.Range(1, foods.Length);
        //GetComponent<>().gameObject = foods[rndFood];
    }
}
