using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;
  private float xSpawnRange = 15;
  private float zSpawnRange = 30;
  private float startDelay = 2;
  public float spawnInterval = Random.Range(3,5);
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
      int animalIndex = Random.Range(0, animalPrefabs.Length);
      Vector3 spawnpos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnRange);
      Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
