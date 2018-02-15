using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth;
	float health;

    Animator animationController;
	//bool isDead =false;
	// Use this for initialization
	void Start () {
        animationController = GetComponent<Animator>();
		health = maxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
            animationController.SetBool("isDead", true);
            GameOver();
		}


	}

	void OnCollisionEnter2D(Collision2D collision){
		GameObject other = collision.gameObject;
		if (other.CompareTag ("Bad")) {
			SwordController sc = other.GetComponent<SwordController> ();
			health -= sc.damage;
		}

	}

    public void GameOver()
    {
        SceneManager.LoadScene("GAMEOVER");
    }



}
