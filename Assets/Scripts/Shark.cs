using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public int damage = 1;

   public void OnTriggerEnter2D(Collider2D trigger){
        if (trigger.CompareTag("Player")){
            trigger.GetComponent<Player>().currentHealth -= damage;
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
