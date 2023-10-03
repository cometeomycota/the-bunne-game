using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] FoodPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 17;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCarrot", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCarrot()
    {
        int FoodIndex = Random.Range(0, FoodPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(FoodPrefabs[FoodIndex], spawnPos, FoodPrefabs[FoodIndex].transform.rotation);
    }
}
