using UnityEngine;

public class OnPlayerCollision : MonoBehaviour {

    void OnTriggerEnter(Collider trigger)
    {
        FindObjectOfType<EndGame>().GameOver();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
