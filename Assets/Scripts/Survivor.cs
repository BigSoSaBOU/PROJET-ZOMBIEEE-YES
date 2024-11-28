using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Survivor : LivingEntity //catégorise les survivors ds la catégorie livingEntity
{
    public Haircolor haircolor; //attribuer une couleur en fonction du script haircolor

    //settings généraux de la catégorie survivor
    float TimeToDeathByHunger = 200;
    float TimeToDeathByThirst = 200;

    float EatDuration = 10; //à attribuer au sources de nourriture et eau pour utiliser ce temps
    float DrinkDuration = 6;

    float CriticalPercent = 0.7f; //critique de lvl de faim ou soif

    //state :
    [Header("State")]
    public float hunger; //montrer faim et soif
    public float thirst;

    protected LivingEntity foodTarget; //les living entity sont des food target
   // protected Water waterTarget; //script de Water à faire !!!!

     void Update()
    {
 

        // Increase hunger and thirst over time
        hunger += Time.deltaTime * 1 / TimeToDeathByHunger;
        thirst += Time.deltaTime * 1 / TimeToDeathByThirst;


        if (hunger >= 1) //si hunger à 1, exécuter fonction mort (définie dans le script living entity)
        {
            Die();
            messageText.text = " -1 mort de faim";
            return; 
        }

        if (thirst >=1)
        {
            Die();
            messageText.text = "-1 mort de soif" ;
            return ;
        }
        
    }
    public TMP_Text messageText;
}
    
