using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIHunger : MonoBehaviour
{
    public GHunger faimManager; // Référence au script FaimManager
    public Slider faimSlider; // Référence à la barre de faim (Slider)

    void Update()
    {
        // Mettre à jour la valeur de la barre de faim
        faimSlider.value = faimManager.hunger;
    }
}
