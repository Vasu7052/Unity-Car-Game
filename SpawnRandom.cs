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

	int insidePositions = {-2.5,0,2.5};

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
			Vector3 spawnPos = new Vector3 (insidePositions[Random.Range(0,3)],6,cameraObject.transform.position.z+2);
			Debug.Log (spawnPos);
			GameObject newSapwnObject = Instantiate (obstacles[randObstacle],spawnPos,gameObject.transform.rotation) as GameObject ;
			if(randObstacle == 0){
				newSapwnObject.transform.localScale = new Vector3 (1f,1f,1f);
			}else if(randObstacle == 1){
				newSapwnObject.transform.localScale = new Vector3 (1f,1.5f,0.5f);
			}
			yield return new WaitForSeconds (spawnWait);
		}

	}

}
























