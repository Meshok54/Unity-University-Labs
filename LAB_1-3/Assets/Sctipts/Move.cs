using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidbody;

    [SerializeField]
    Sprite damage1;    
    [SerializeField]
    Sprite damage2;

    int totalBlocks = 12;

    void Start()
    {
        rigidbody.linearVelocity = new Vector2(Random.Range(4f, 6f), Random.Range(4f, 6f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Lose"))
        {
            Debug.Log("Are you LOSE!!!");
            Time.timeScale = 0f;
        }
       if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            totalBlocks--;
            if(totalBlocks == 0)
            {
                Debug.Log("Are you WIN!!!");
                Time.timeScale = 0f;
            }

        } 
       if (collision.gameObject.CompareTag("Block1"))
        {
            collision.gameObject.tag = "Block";
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = damage2;
        }       
       if (collision.gameObject.CompareTag("Block2"))
        {
            collision.gameObject.tag = "Block1";
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = damage1;
        }
    }
}
