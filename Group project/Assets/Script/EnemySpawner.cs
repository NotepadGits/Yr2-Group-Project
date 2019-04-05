using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject player;
	public GameObject enemy;
	public GameObject spawner_W;
	public GameObject spawner_N;
	public GameObject spawner_E;
	public GameObject spawner_S;

	/* Find player position in world space
	 * decide what pole to spawn the enemy at.
	 * Set enemy position to spawn pole position.
	 * instantiate enemy at pole position.
	 * 
	 * 
	 */

		//player position.
	float playerPosX;
	float playerPosZ;

	//spawn pole locations
	Vector3 spawnerPosition_W;
	Vector3 spawnerPosition_N;
	Vector3 spawnerPosition_E;
	Vector3 spawnerPosition_S;


	void Start()
	{
		InvokeRepeating("EnemySpawnLocation", 0.0f, 2.0f);
	}

    // Update is called once per frame
    void Update()
    {

		//tell the console the updated position of the player. Just want to check I can find where the player is in space.
		playerPosX = player.transform.position.x;
		playerPosZ = player.transform.position.z;


		//Debug.Log("player pos is: " + playerPosX);

		//Assign actual position to Vec3's.
		spawnerPosition_W = spawner_W.transform.position;
		spawnerPosition_N = spawner_N.transform.position;
		spawnerPosition_E = spawner_E.transform.position;
		spawnerPosition_S = spawner_S.transform.position;

	}

	//method that checks where the player is in world space. Where they are depends where they spawn.
	void EnemySpawnLocation()
	{
		if (playerPosX > 0)
		{
			Instantiate(enemy, spawnerPosition_W, Quaternion.identity);
		}

		if (playerPosX < 0)
		{
			Instantiate(enemy, spawnerPosition_E, Quaternion.identity);
		}

		if (playerPosZ < 0)
		{
			Instantiate(enemy, spawnerPosition_N, Quaternion.identity);
		}

		if (playerPosZ > 0)
		{
			Instantiate(enemy, spawnerPosition_S, Quaternion.identity);
		}

	}
}
