using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableBox : MonoBehaviour
{
    Rigidbody rb;
    Settings settings;

    private void Start () {
        rb = GetComponent<Rigidbody> ();
        settings = FindObjectOfType<Settings> ();
    }

    void OnMouseDown () 
    {
        Vector3 RotationalForce = settings.GetRotationalForce ();

        // ADD CODE HERE
    }
}
