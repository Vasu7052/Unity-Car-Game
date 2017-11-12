using UnityEngine;
using System.Collections;

public class SpawnRandom : MonoBehaviour {

	public GameObject cameraObject ;
	public GameObject[] obstacles;
	public Vector3 spawnValues ;
	public float spawnWait;
	public float spawnMostWait ;
	public float spawnLeastWait ;
	public int startWait;
	public bool stop ;

	int randObstacle ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);

		while(!stop){
			randObstacle = Random.Range (0, 2);
			Vector3 spawnPos = new Vector3 (Random.Range(-8,8),6,cameraObject.transform.position.z+3);
			Instantiate (obstacles[randObstacle],spawnPos+transform.TransformPoint(0,0,0));
		}

	}

}
























