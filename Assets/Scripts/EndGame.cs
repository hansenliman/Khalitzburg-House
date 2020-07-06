using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public float restartDelay = 1f;

    public void GameOver()
    {
        FindObjectOfType<Canvas>().enabled = true;
        FindObjectOfType<FirstPersonController>().enabled = false;
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
