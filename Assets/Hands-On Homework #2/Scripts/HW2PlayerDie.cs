using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    public GameObject endPane;
    private string Enemy = "Enemy"; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == Enemy)
        {
            endPane.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
