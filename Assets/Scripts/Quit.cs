using UnityEngine;

public class Quit : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
