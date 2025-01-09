using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zombies : LivingEntity
    
{
    public TMP_Text messageText;
    public float hunger;
    float TimeToDeathByHunger = 100;
    // Increase hunger and thirst over time

    private void Update()
    {
        hunger += Time.deltaTime * 1 / TimeToDeathByHunger;

        if (hunger >= 1) //si hunger � 1, ex�cuter fonction mort (d�finie dans le script living entity)
        {
            Die();
            messageText.text = " UN ZOMBIE EST MORT";
            return;
        }
    }


}
