using UnityEngine;
using System.Collections;

public class SpawnRoad : MonoBehaviour {

	float currentTrackNumber;
	public float lengthOfTrack ;
	public GameObject[] roads ;
	int randRoad ;
	bool isTriggered=false ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if(col.tag == "SpawnBar"){
			if (isTriggered)
				return;
			Debug.Log ("Triggered1");
			currentTrackNumber = gameObject.transform.position.z / lengthOfTrack;
			currentTrackNumber = Mathf.Ceil (currentTrackNumber);
			if(currentTrackNumber <= 0f){
				currentTrackNumber = 1f;
			}
			randRoad = Random.Range (0, 2);
			GameObject spawnRoad = Instantiate (roads[randRoad] , new Vector3(0f,6f,(currentTrackNumber*lengthOfTrack)) , gameObject.transform.rotation) as GameObject;
			Debug.Log (currentTrackNumber*lengthOfTrack);
			spawnRoad.transform.localScale = new Vector3 (1f,1f,1f);
			Destroy (col.gameObject);
			isTriggered = true;
			System.Threading.Thread.Sleep (2000);
		}
	}



}
