using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;

    public int speed = 10;
    string VariableOne = "Hello ";
    public string nextLevel = "Level 2";
    // Start is called before the first frame update
    void Start()

    { 
        rb = GetComponent<Rigidbody2D>();
        string VariableTwo = "World";

        Debug.Log(VariableOne + VariableTwo);
    }

    // Update is called once per frames
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.W))
            transform.position += new Vector3(0, 2, 0);
       
            if(Input.GetKeyDown(KeyCode.S))
                transform.position += new Vector3(0, -2, 0);
        if (Input.GetKeyDown(KeyCode.A))
            transform.position += new Vector3(-2, 0, 0);
        if (Input.GetKeyDown(KeyCode.D))
            transform.position += new Vector3(2, 0, 0);
        */

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
           
                string thisLevel = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(thisLevel);
                break;
            case "Finish":
                SceneManager.LoadScene(nextLevel);
                break;
        }
    }
}

