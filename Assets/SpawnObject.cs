using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

    //Value given from editor
    public GameObject prefabToSpawn = null;
    GameObject _spawnedObject = null;

    // Use this for initialization
    void Start () { 
        _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
        _spawnedObject.name = "Bubble Girl";

        //Setting ourselves to be the parent
        _spawnedObject.transform.parent = transform;

    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
