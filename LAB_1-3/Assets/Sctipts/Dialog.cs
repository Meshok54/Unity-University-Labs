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
}
