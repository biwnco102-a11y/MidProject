using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        transform.Translate(move * speed * Time.deltaTime, 0, 0);
    }
}