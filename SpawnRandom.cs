using UnityEngine;
using System.Collections;

public class SpawnRandom : MonoBehaviour {

	public GameObject cameraObject ;
	public GameObject[] obstacles;
	public float spawnWait;
	public float spawnMostWait ;
	public float spawnLeastWait ;
	public int startWait;
	public bool stop ;

	int randObstacle ;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawner ());
	}
	
	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range (spawnLeastWait,spawnMostWait);
	}

	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);

		while(!stop){
			randObstacle = Random.Range (0, 2);
			Vector3 spawnPos = new Vector3 (Random.Range(-4,4),6,cameraObject.transform.position.z+2);
			Instantiate (obstacles[randObstacle],spawnPos+transform.TransformPoint(0,0,0),gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}

	}

}
























