using UnityEngine;

public class Make_Zombie_Sound : MonoBehaviour {
    
    public AudioClip walkSound1;
    public AudioClip walkSound2;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("PlayWalk1", 0.001f, 2f);
        InvokeRepeating("PlayWalk2", 1.001f, 2f);
    }

    void PlayWalk1()
    {
        GetComponent<AudioSource>().PlayOneShot(walkSound1);
    }

    void PlayWalk2()
    {
        GetComponent<AudioSource>().PlayOneShot(walkSound2);
    }
}
