using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    public string Next_Level = "Geo_Quest_Scene_2";
    private Rigidbody2D rb;
    public int speed = 5;
    private SpriteRenderer spriteRenderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(Next_Level);
                    break;
                }
            case "Coin":
                {
                    Destroy(collision.gameObject);
                    break;
                }

        }
    }


    string VariableOne = "Hello ";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        string VariableTwo = "World";

        Debug.Log(VariableOne + VariableTwo);
    }

    // Update is called once per fram
    void Update()

    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);

        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1)) spriteRenderer.color = Color.red;
        if (Input.GetKeyDown(KeyCode.Alpha2)) spriteRenderer.color = Color.green;
        if (Input.GetKeyDown(KeyCode.Alpha3)) spriteRenderer.color = Color.blue;
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
}


