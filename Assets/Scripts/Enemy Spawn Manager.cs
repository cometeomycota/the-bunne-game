using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour

    {
         public GameObject[] GhostPrefabs;
    private float spawnRangeZ = 17.6f;
    private float spawnPosY = 1;
    private float startDelay = 1;
    private float spawnInterval = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGhost", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
        

    }
    void SpawnGhost()
    {
        int GhostIndex = Random.Range(0, GhostPrefabs.Length);
        Vector3 spawnPos = new Vector3(22.7f, spawnPosY, Random.Range(spawnRangeZ, -spawnRangeZ));
        Instantiate(GhostPrefabs[GhostIndex], spawnPos, GhostPrefabs[GhostIndex].transform.rotation);
    }
}
