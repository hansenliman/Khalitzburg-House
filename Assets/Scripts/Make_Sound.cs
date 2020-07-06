using UnityEngine;

public class Make_Sound : MonoBehaviour {

    public AudioClip sfx;

	// Use this for initialization
	void Start () {
        InvokeRepeating("PlaySound", 0.001f, 4f);
	}
	
    void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(sfx);
    }

	// Update is called once per frame
	void Update () {
        
	}
}
