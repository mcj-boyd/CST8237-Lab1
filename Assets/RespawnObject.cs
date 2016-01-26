using UnityEngine;
using System.Collections;

public class RespawnObject : MonoBehaviour {

    public GameObject prefabToSpawn = null;
    public float distanceForSpawn = 5;
    private bool respawned = false;
    private Vector3 spawnPosition;

    // Use this for initialization
    void Start()
    {
        spawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (respawned == false)
        {
            if( Vector3.Distance(spawnPosition, transform.position) > distanceForSpawn)
            {
                GameObject _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
                _spawnedObject.name = "Bubble Girl Clone";

                _spawnedObject.transform.position = transform.position;
                respawned = true;
            }
        }
    }
}
