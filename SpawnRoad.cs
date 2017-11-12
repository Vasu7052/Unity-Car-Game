using UnityEngine;
using System.Collections;

public class SpawnRoad : MonoBehaviour {

	public float currentTrackNumber;
	public float lengthOfTrack = 30f ;
	public GameObject road ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentTrackNumber = gameObject.transform.position.z / lengthOfTrack;
		Debug.Log (System.Math.Round(currentTrackNumber,0));
		if(gameObject.transform.position.z == ((currentTrackNumber+1)*lengthOfTrack-15)){
			GameObject spawnRoad = Instantiate (road , new Vector3(0f,6f,((currentTrackNumber+1)*lengthOfTrack)) , gameObject.transform.rotation);
			spawnRoad.transform.localScale = new Vector3 (1f,1f,1f);
		}

	}
}
