
using System;

using UnityEngine;

public class MortalUtility : MonoBehaviour {

	public int hitPoints;
	public string[] killingTags;
	public GameObject objectToSpawnOnDestroy;

	private void OnCollisionEnter (Collision collision) {

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
