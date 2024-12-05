using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuivrePersonnage : MonoBehaviour
{
    public Transform personnage; // Le personnage à suivre
    public Vector3 offset = new Vector3(0, 2, 0); // Décalage au-dessus de la tête

    void LateUpdate()
    {
        // Met à jour la position de la barre en fonction du personnage
        transform.position = personnage.position + offset;
    }
}