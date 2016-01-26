using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float minDistance = 1f;
    public float maxDistance = 5f;
    public float movementSpeed = 1f;

    bool movingOut = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 position = transform.localPosition;

        if(position.x > maxDistance)
        {
            movingOut = false;
        }
        if(position.x < minDistance)
        {
            movingOut = true;
        }

        if (movingOut)
        {
            position.x += (movementSpeed * Time.deltaTime);
        }
        else
        {
            position.x -= (movementSpeed * Time.deltaTime);
        }

        transform.localPosition = position;
    }
}
