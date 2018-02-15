using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
    public GameObject spawnee;
    public float spawnDelay = 4f;

    float timer = 0;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 target = new Vector3(transform.position.x,
            player.transform.position.y, 0);

        
		if (timer >= spawnDelay)
        {
            Instantiate(spawnee, target, Quaternion.identity);
            timer = 0;
        }

        timer += Time.deltaTime;
	}
}
