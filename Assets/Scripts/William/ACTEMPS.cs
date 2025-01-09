using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTEMPS : MonoBehaviour
{
    public float maxTimeScale = 5.0f; // vitesse max
    public float timeStep = 0.5f; // Increment de vitesse 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //fleche du haut pour accelerer 
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale + timeStep, 1.0f, maxTimeScale);
            Debug.Log("Temps accelere :" + Time.timeScale);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //fleche du bas pour ralentir 
        {
            Time.timeScale = Mathf.Clamp(Time.timeScale - timeStep, 0.1f, maxTimeScale);
            Debug.Log("Temps ralenti:" + Time.timeScale);

        }

        if (Input.GetKey(KeyCode.R)) //reinitilisation : R
        {
            Time.timeScale = 1.0f;
            Debug.Log("Retout à la vitesse normal" + Time.timeScale);
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }   

}






