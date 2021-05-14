using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;

    public float xIncrement;
    public float maxXOffset;

    public int score = 0;
    public int maxHealth;
    public int currentHealth;

    public float speed;

    public Text healthDisplay;
    public Text scoreDisplay;

    void Start()
    {
        currentHealth = 3;
    }

    // Update is called once per frame
    void Update()   {

        healthDisplay.text = "HP: " + currentHealth.ToString();
        scoreDisplay.text = "Score: " + score.ToString();

        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        transform.Translate(Vector2.up * speed);

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1*maxXOffset){
            targetPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
            transform.position = targetPos;
        } else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < maxXOffset){
            targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
            transform.position = targetPos;
        } else if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (touchPos.x < 0 && transform.position.x > -1 * maxXOffset) {
                targetPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
                transform.position = targetPos;
            } else if (touchPos.x >= 0 && transform.position.x < maxXOffset)
            {
                targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
                transform.position = targetPos;
            }
        }

    }
}
