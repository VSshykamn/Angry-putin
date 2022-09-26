using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLevel2 : MonoBehaviour
{
	public GameObject deathEffect;

	public float health = 4f;

	public static int EnemiesAlive = 0;

	void Start()
	{
		EnemiesAlive++;
	}

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);

		EnemiesAlive--;
		if (EnemiesAlive <= 0)
			Debug.Log("LEVEL WON!");

		Destroy(gameObject);
		GoToLevel3();

	}
	void GoToLevel3()
	{
		if (EnemiesAlive <= 0)
			SceneManager.LoadScene(3);

	}
}
