using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public int healing = 1;

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            if (trigger.GetComponent<Player>().currentHealth < trigger.GetComponent<Player>().maxHealth){
                trigger.GetComponent<Player>().currentHealth += healing;
            }
            Destroy(gameObject);
        }

    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("MainCamera").transform.position.y - transform.position.y >= 20)
        {
            Destroy(gameObject);//should destroy objects after they are far offscreen
        }
    }

}