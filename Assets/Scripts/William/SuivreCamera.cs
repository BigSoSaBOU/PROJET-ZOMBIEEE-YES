using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuivreCamera : MonoBehaviour
{
    void LateUpdate()
    {
        // Faire en sorte que cet objet (la barre) regarde toujours la cam�ra
        transform.forward = Camera.main.transform.forward;
    }
}
