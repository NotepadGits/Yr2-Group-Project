using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
	/* find and insert player position.
	 * update enemy position to move towards the player. 
	 */

	public GameObject player;
	public GameObject enemy;

	public float moveSpeed = 5;

	Vector3 playerPosition;
	Vector3 enemyPosition;

	Transform target;

    // Update is called once per frame
    void Update()
    {
		//rotate the object to be looking at the player. (!Not sure if this is necessary).
		transform.LookAt(target);

		//set the transform of the player to current player position.
		target = player.transform;

		//if the x position of the enemy is not equal to the player's x position, then move towards that x position.

		//update the position of the enemy to move towards the player. multiply by time.deltatime to not fly there lol.
		transform.position += transform.forward * moveSpeed * Time.deltaTime;



		Debug.Log("tracking position : " + target);

    }

	void OnCollisionEnter(Collision target)
	{
		//Destroy(this.gameObject);
	}
}
