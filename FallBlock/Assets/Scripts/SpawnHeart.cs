using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHeart : MonoBehaviour
{
    [SerializeField] private float minX = 0.0f;
    [SerializeField] private float maxX = 0.0f;
    [SerializeField] private GameObject heart;

    [SerializeField] private float timeBetweenSpawns = 0.0f;
  
    private bool canSpawn = false;


//    private int amountOfHeatToSpawn = 0;
    void Start()
    {
        canSpawn = true;
    }


    void Update()
    {
        if (canSpawn) StartCoroutine("GenerateHeart");
        
    }

    private IEnumerator GenerateHeart()
    {
        canSpawn = false;


        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0, 0);
        Instantiate(heart, spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(timeBetweenSpawns);
        canSpawn = true;
    }
}