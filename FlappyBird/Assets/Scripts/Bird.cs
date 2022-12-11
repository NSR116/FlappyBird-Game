using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public Vector3 direction;
    public float gravity = -9.8f;
    public float diffuclty = 5f;
    private SpriteRenderer render;
    public GameObject rocket;

    // This method auto call by Unity, only once per whole life cycle of the script
    private void Awake()
    {
        render = GetComponent<SpriteRenderer>();
    }

    //private void Start()
    //{
    //    FindObjectOfType<GameManager>().play();
    //}

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))//zero mean the left mouse click
        {
            direction = Vector3.up * diffuclty;

            GetComponent<AudioSource>().Play();
            rocket.SetActive(true);
        }
        else
        {
            rocket.SetActive(false);
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    // To detect collision with bird
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().gameOver();
        }
        else if(collision.gameObject.tag == "Score")
        {
            FindObjectOfType<GameManager>().incScore();

        }
    }

}
