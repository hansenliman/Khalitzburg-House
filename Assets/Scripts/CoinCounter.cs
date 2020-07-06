using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour {

    private int totalCoins = 0;

    public void AddCoin()
    {
        totalCoins++;
        if(totalCoins == 1)
        {
            GameObject[] zombies;
            zombies = GameObject.FindGameObjectsWithTag("Zombies W2");
            foreach(GameObject zombie in zombies)
            {
                zombie.GetComponent<CapsuleCollider>().enabled = true;
                zombie.GetComponent<Make_Zombie_Sound>().enabled = true;
                zombie.GetComponent<NavMeshAgent>().enabled = true;
                zombie.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        else if(totalCoins == 2)
        {
            GameObject[] whispers;
            whispers = GameObject.FindGameObjectsWithTag("Whispers W3");
            foreach (GameObject whisper in whispers)
            {
                whisper.GetComponent<CapsuleCollider>().enabled = true;
                whisper.GetComponent<Make_Sound>().enabled = true;
                whisper.GetComponent<NavMeshAgent>().enabled = true;
                whisper.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        else if (totalCoins == 3)
        {
            GameObject[] nightmares;
            nightmares = GameObject.FindGameObjectsWithTag("Nightmares W4");
            foreach (GameObject nightmare in nightmares)
            {
                nightmare.GetComponent<CapsuleCollider>().enabled = true;
                nightmare.GetComponent<MakeNightmareSound>().enabled = true;
                nightmare.GetComponent<NavMeshAgent>().enabled = true;
                nightmare.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        else if(totalCoins == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
