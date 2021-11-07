
using UnityEngine;

public class SpawnWithUtility : MonoBehaviour {

    public GameObject objectToCreateOnStart, objectToCreateOnDestroy, objectToCreateOnCollision;

    private void Start () {

        if (objectToCreateOnSpawn == null) return;

        Instantiate(objectToCreateOnSpawn, transform.position, transform.rotation);
    }

    private void OnCollisionEnter () {

        if (objectToCreateOnCollision == null) return;

        Instantiate(objectToCreateOnCollision, transform.position, transform.rotation);
    }

    private void Destroy () {

        if (objectToCreateOnDestroy == null) return;

        Instantiate(objectToCreateOnDestroy, transform.position, transform.rotation);
    }
}
