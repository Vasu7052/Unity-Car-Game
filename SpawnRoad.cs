using UnityEngine;
using System.Collections;

public class SpawnRoad : MonoBehaviour {

	float currentTrackNumber;
	public float lengthOfTrack = 30f ;
	public GameObject[] roads ;
	int randRoad ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentTrackNumber = gameObject.transform.position.z / lengthOfTrack;
		currentTrackNumber = Mathf.Ceil (currentTrackNumber);
		if(gameObject.transform.position.z > ((currentTrackNumber*lengthOfTrack)-25) && gameObject.transform.position.z < ((currentTrackNumber*lengthOfTrack)-24)){
			randRoad = Random.Range (0, 3);
			GameObject spawnRoad = Instantiate (roads[randRoad] , new Vector3(0f,6f,((currentTrackNumber)*lengthOfTrack)) , gameObject.transform.rotation) as GameObject;
			spawnRoad.transform.localScale = new Vector3 (1f,1f,1f);
		}

	}

	void OnCollisionEnter(Collider col){
		if(col.gameObject.name == "SpawnBar"){
			Debug.Log ("Triggered");
		}
	}

	void OnTriggerEnter(Collider col){
			Debug.Log ("Triggered1");
	}



}
