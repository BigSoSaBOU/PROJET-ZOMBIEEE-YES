using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour //script pour d�finir des choses sp�cifiques � toutes leschose qui ont la cat�gorie livingEntity
{
    public void Die() //fonction die d�finie comme : d�truire object en question
    {
        Destroy(gameObject);
    }
}
