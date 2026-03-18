using UnityEngine;

public class Brick : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
}