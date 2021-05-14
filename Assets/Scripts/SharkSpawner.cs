using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    public Transform thePlayer;

    private Vector3 offset;

    public GameObject[] sharkPatterns;

    GameObject referenceObject;
    Player referenceScript;

    private float toNextSpawn; //determines time until next wave of sharks. 
    public float initSpawnRate; //initial total time between waves
    public float maxRate; //determines fastest speed at which sharks spawn
    public float spawnChange; //how much the difference in spawn time changes after each wave

    void Start()
    {
        offset = transform.position - thePlayer.position;
    }

    void Update(){
        if (toNextSpawn <= 0){

            int rand = Random.Range(0, sharkPatterns.Length);
            Instantiate(sharkPatterns[rand], transform.position, Quaternion.identity);
            Debug.Log("Spawn");
            toNextSpawn = initSpawnRate;
            if (initSpawnRate > maxRate){
                initSpawnRate -= spawnChange;
            }
        }
        else {
            toNextSpawn -= Time.deltaTime;
        }
    }

    void LateUpdate()
    {
        Vector3 newPos = new Vector3(0, thePlayer.position.y + offset.y, thePlayer.position.z + offset.z);

        transform.position = newPos;
    }
}
