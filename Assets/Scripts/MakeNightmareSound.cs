using UnityEngine;

public class MakeNightmareSound : MonoBehaviour {

    public AudioClip walkSound1;
    public AudioClip walkSound2;
    public AudioClip walkSound3;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("PlayWalk1", 0.001f, 0.6f);
        InvokeRepeating("PlayWalk2", 0.071f, 0.6f);
        InvokeRepeating("PlayWalk3", 0.141f, 0.6f);
    }

    void PlayWalk1()
    {
        GetComponent<AudioSource>().PlayOneShot(walkSound1);
    }

    void PlayWalk2()
    {
        GetComponent<AudioSource>().PlayOneShot(walkSound2);
    }

    void PlayWalk3()
    {
        GetComponent<AudioSource>().PlayOneShot(walkSound2);
    }
}

