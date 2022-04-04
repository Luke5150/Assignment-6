/*
 * (Luke Hensley)
 * (Assignment 6)
 * (Controls player movement)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jumpPower = 10;
    public bool isGrounded = true;
    public int score;

    public Text scoreText;

    public GameObject manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
      
      transform.position = new Vector3(transform.position.x + speed * Input.GetAxis("Horizontal") * Time.deltaTime, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        if(gameObject.transform.position.y < 210)
        {
            manager.GetComponent<GameManager>().UnloadCurrentLevel();
        }

        scoreText.text = "Score: " + score;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true; 
        }

        else if(collision.gameObject.tag == "Coin")
        {
            score = collision.gameObject.GetComponent<CoinBehavior>().addScore(1, score);
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "WinCoin")
        {
            score = collision.gameObject.GetComponent<CoinBehavior>().addScore(5, score);
            Destroy(collision.gameObject);
        }
    }
}
