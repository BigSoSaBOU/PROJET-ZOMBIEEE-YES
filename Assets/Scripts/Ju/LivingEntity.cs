using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour //script pour définir des choses spécifiques à toutes leschose qui ont la catégorie livingEntity
{
    public void Die() //fonction die définie comme : détruire object en question
    {
        Destroy(gameObject);
    }
}
