using UnityEngine;

public class Dialog : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "Ground")
        {
            Debug.Log("Stolknulsya s zemlei");
        }
        else if (myCollision.gameObject.name == "Wall")
        {
            GameObject wall = GameObject.Find("Wall");
            Object.Destroy(wall);
            Debug.Log("Stolknulsya so stenoi i stena razrushilas");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
