
using UnityEngine;

public class RotateUtility : MonoBehaviour {

	public Vector3 rotationSpeeds;

	private void Update () {

		transform.position += rotationSpeeds;
	}
}