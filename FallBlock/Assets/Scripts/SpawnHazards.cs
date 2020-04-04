using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHazards : MonoBehaviour
{
    #region Variables

    //Public


    //Private
    [SerializeField] private float minX = 0.0f;
    [SerializeField] private float maxX = 0.0f;
    [SerializeField] private GameObject[] hazards; //Potential array of hazards
    [SerializeField] private float timeBetweenSpawns = 0.0f;
    private bool canSpawn = false;
    private int amountOfHazardsToSpawn = 0;
    private int hazardsToSpawn = 0;

    #endregion


    #region UnityFunctions

    void Start()
    {
        canSpawn = true;
    }

    void Update()
    {
        if (canSpawn == true) StartCoroutine("GenerateHazard");
    }

    #endregion

    private IEnumerator GenerateHazard()
    {
        canSpawn = false;
        timeBetweenSpawns = Random.Range(0.5f, 2.0f); //Testing values
        amountOfHazardsToSpawn = Random.Range(1, 6); //Testing values

        for (int i = 0; i < amountOfHazardsToSpawn; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), 8.0f, 0.1f); //Generate a spawn position
            Instantiate(hazards[hazardsToSpawn], spawnPos, Quaternion.identity); //Spawn the hazards
        }

        yield return new WaitForSeconds(timeBetweenSpawns);
        canSpawn = true;
    }
}