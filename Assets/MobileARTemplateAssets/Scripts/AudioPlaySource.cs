using UnityEngine;

public class AudioPlaySource : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Play()
    {
        audioSource.Play();
    }
}
