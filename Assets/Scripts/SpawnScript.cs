using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    
    public float SpawnTimeSeconds;
    public GameObject ObjectToSpawn;
    public float TimePassed = 0.0f; 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
     {
         TimePassed += Time.deltaTime;
 
         if (TimePassed > SpawnTimeSeconds)
         {
             TimePassed = 0;
             Debug.Log("Spawning new Enemy");   
              Vector3 spawnPosition = transform.position;
              GameObject newEnemy = (GameObject)Instantiate(ObjectToSpawn, spawnPosition, Quaternion.Euler (0, 0, 0));
         }
     }
}