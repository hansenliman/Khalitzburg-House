using UnityEngine;
using UnityEngine.AI;

public class FlashLight : MonoBehaviour {

    public Light myLight;
    public string flashButton = "ToggleFlashLight";

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown(flashButton))
        {
            myLight.enabled = !myLight.enabled;
            if (myLight.enabled)
            {
                ModifySpeed("Zombies W2", 2.5f);
                ModifySpeed("Whispers W3", 1.8f);
                ModifySpeed("Nightmares W4", 1.5f);
            }
            else
            {
                ModifySpeed("Zombies W2", (1/2.5f));
                ModifySpeed("Whispers W3", (1/1.8f));
                ModifySpeed("Nightmares W4", (1/1.5f));
            }
        }

    }

    void ModifySpeed(string monsterTag, float speedModifier)
    {
        GameObject[] monsters;
        monsters = GameObject.FindGameObjectsWithTag(monsterTag);
        foreach (GameObject monster in monsters)
        {
            monster.GetComponent<NavMeshAgent>().speed *= speedModifier;
        }
    }
}
