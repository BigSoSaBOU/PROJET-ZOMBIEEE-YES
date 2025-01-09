using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIHunger : MonoBehaviour
{
    public GHunger faimManager; // R�f�rence au script FaimManager
    public Slider faimSlider; // R�f�rence � la barre de faim (Slider)

    void Update()
    {
        // Mettre � jour la valeur de la barre de faim
        faimSlider.value = faimManager.hunger;
    }
}
