using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuivrePersonnage : MonoBehaviour
{
    public Transform personnage; // Le personnage � suivre
    public Vector3 offset = new Vector3(0, 2, 0); // D�calage au-dessus de la t�te

    void LateUpdate()
    {
        // Met � jour la position de la barre en fonction du personnage
        transform.position = personnage.position + offset;
    }
}