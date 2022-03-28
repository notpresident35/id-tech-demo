using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Vector3 Force;
    public float RotationSpeed;

    public Vector3 GetRotationalForce () {
        Vector3 randVector = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f)).normalized;
        return RotationSpeed * randVector;
    }
}
