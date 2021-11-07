
using System;

using UnityEngine;

public class MortalUtility2D : MonoBehaviour {

	public int hitPoints;
	public string[] killingTags;
	public GameObject objectToSpawnOnDestroy;

	private void OnCollisionEnter2D (Collision2D collision) {

		bool damageTaken = false;

		if (killingTags.Length == 0) damageTaken = true;
		else if (Array.IndexOf(killingTags, collision.collider.tag) > -1)
			damageTaken = true;

		if (damageTaken) {

			hitPoint--;

			if (hitPoints <= 0) {

				if (objectToSpawnOnDestroy != null)
					Instiantiate(objectToSpawnOnDestroy, transform.position, transform.rotation);

				Destroy(gameObject);
			}
		}
	}
}
