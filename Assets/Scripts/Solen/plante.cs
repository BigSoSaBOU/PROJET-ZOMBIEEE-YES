using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plante : MonoBehaviour

{
    private survivant survivantPresent = null;

    private void Update()
    {
        if (survivantPresent != null)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        survivant survivantDetect = collision.gameObject.GetComponent<survivant>();
        if (survivantDetect != null)
        {
            survivantPresent = survivantDetect;
        }
    }
}

