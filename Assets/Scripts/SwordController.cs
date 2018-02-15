using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {
	Rigidbody2D rb;
	public float speed = 3;
	public float damage = 20;
    public int numberOfSwords = 3;

    private Vector2 swordOffset = new Vector2(0f, 2f);

    ImportantVariables swordManager;
    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D> ();
        swordManager = Camera.main.GetComponent<ImportantVariables>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = -transform.right*speed;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (swordManager.swordCount >= swordManager.maxSwords)
        {
            return;
        }


        GameObject sword1 = Instantiate(gameObject, 
            collision.contacts[0].point + swordOffset, 
            Quaternion.Euler(0f, 0f, 300f));
        GameObject sword2 = Instantiate(gameObject, collision.contacts[0].point - swordOffset,
            Quaternion.Euler(0f, 0f, -300f));

        sword1.transform.localScale = transform.localScale / 2f;
        sword2.transform.localScale = transform.localScale / 2f;
        swordManager.swordCount++;
    
        Destroy(gameObject);
    }
}
