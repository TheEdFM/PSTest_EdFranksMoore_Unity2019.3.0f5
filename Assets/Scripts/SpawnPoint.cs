using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject shark;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shark, transform.position, Quaternion.identity);
    }
}
