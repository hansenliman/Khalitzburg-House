using UnityEngine;

public class Interact : MonoBehaviour {

    public string interactButton;
    public float interactDistance = 3f;
    public LayerMask interactLayer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position , transform.forward);
        RaycastHit hit;
        

        if(Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            if (Input.GetButtonDown(interactButton))
            {
                if (hit.collider.CompareTag("Coin"))
                {
                    hit.collider.GetComponent<Interaction>().pickUp();
                    FindObjectOfType<CoinCounter>().AddCoin();
                }
            }
        }
	}
}
