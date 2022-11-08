using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] humanPrefabs;
    private float spawnRangeX = 19;
    private float spawnLocationZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, humanPrefabs.Length);
            Vector3 spawnLocation = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnLocationZ);

            Instantiate(humanPrefabs[animalIndex], spawnLocation, humanPrefabs[animalIndex].transform.rotation);
        }
    }
}
