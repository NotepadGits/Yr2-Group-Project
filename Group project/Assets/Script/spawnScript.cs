using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
	public GameObject enemy;
	private float repeatRate = 5.0f;

	public Transform radiusObject;
	public Transform spawnerObject;

	// Start is called before the first frame update
	void Start()
	{
		for (int i = 0; i < 3; i++)
		{
			radiusObject.position = spawnerObject.position;
		}
	}

	void EnemySpawner()
	{
		Instantiate(enemy, spawnerObject.position, spawnerObject.rotation);
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void onTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Spawner")
		{
			InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
			Destroy(gameObject, 11);
			gameObject.GetComponent<BoxCollider>().enabled = false;

		}
	}

}