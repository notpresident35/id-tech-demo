using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject BallPrefab;
    public Vector3 Force;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            GameObject newBall = Instantiate (BallPrefab, Vector3.zero, Quaternion.identity, null);

            // ADD CODE HERE
        }
    }
}
