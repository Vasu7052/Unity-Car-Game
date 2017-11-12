using UnityEngine;
using System.Collections;

public class SpawnRandom : MonoBehaviour {

	public GameObject cameraObject ;
	public GameObject[] obstacles;
	public GameObject[] outsideObstacles; 
	public float spawnWait;
	public float spawnMostWait ;
	public float spawnLeastWait ;
	public int startWait;
	public bool stop ;

	int randObstacle,randSideObjects;

	float[] insidePositions = {-2.5f,0f,2.5f};
	float[] outsidePositions = {-6.5f,6.5f};

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawner ());
		StartCoroutine (OutsideSpawner ());
	}
	
	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range (spawnLeastWait,spawnMostWait);
	}

	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);

		while(!stop){
			randObstacle = Random.Range (0, 4);
			Vector3 spawnPos;
			GameObject newSapwnObject;

			if(randObstacle == 0 || randObstacle == 1){
				spawnPos = new Vector3 (insidePositions[Random.Range(0,3)],6,cameraObject.transform.position.z+2);
				newSapwnObject = Instantiate (obstacles[randObstacle],spawnPos,gameObject.transform.rotation) as GameObject ;
				newSapwnObject.transform.localScale = new Vector3 (1f,1f,1f);
			}else if(randObstacle == 2){
				spawnPos = new Vector3 (insidePositions[Random.Range(0,3)],6,cameraObject.transform.position.z+2);
				newSapwnObject = Instantiate (obstacles[randObstacle],spawnPos,gameObject.transform.rotation) as GameObject ;
				newSapwnObject.transform.localScale = new Vector3 (1f,1.5f,0.5f);
			}else if(randObstacle == 3){
				spawnPos = new Vector3 (insidePositions[Random.Range(0,3)],8,cameraObject.transform.position.z+2);
				newSapwnObject = Instantiate (obstacles[randObstacle],spawnPos,gameObject.transform.rotation) as GameObject ;
				newSapwnObject.transform.localScale = new Vector3 (1f,1f,1f);
			}


			yield return new WaitForSeconds (spawnWait);
		}

	}

	IEnumerator OutsideSpawner(){
		yield return new WaitForSeconds (1);
		while(!stop){
			randSideObjects = Random.Range (0, 1);
			Vector3 outsideSpawnPos = new Vector3 (outsidePositions[Random.Range(0,2)],3.5f,cameraObject.transform.position.z+5);
			GameObject newOutsideSapwnObject = Instantiate (outsideObstacles[randSideObjects], outsideSpawnPos, gameObject.transform.rotation) as GameObject;
			newOutsideSapwnObject.transform.localScale = new Vector3 (2f,2f,2f);
			yield return new WaitForSeconds (1);
		}

	}


}
























