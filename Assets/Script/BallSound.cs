using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioClip paddleSound;
    public AudioClip wallSound;
    public AudioClip OrSound;

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Paddle"))
        {
            PlaySound(paddleSound);
        }

        if (c.gameObject.CompareTag("Wall"))
        {
            PlaySound(wallSound);
        }

        if (c.gameObject.CompareTag("Or"))
        {
            PlaySound(OrSound);
        }
    }

    void PlaySound(AudioClip clip)
    {
        AudioSource source = new GameObject().AddComponent<AudioSource>();
        source.clip = clip;
        source.pitch = Random.Range(0.9f, 1.1f);
        source.Play();

        Destroy(source.gameObject, clip.length);
    }
}
