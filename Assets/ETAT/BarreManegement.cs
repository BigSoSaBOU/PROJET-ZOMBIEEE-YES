using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreManegement : MonoBehaviour
{
    public Slider faimSlider; // Premi�re barre
    public Slider energieSlider; // Deuxi�me barre

    public float faimMax = 100f;
    public float energieMax = 100f;

    private float faimActuelle;
    private float energieActuelle;

    void Start()
    {
        faimActuelle = faimMax;
        energieActuelle = energieMax;

        faimSlider.maxValue = faimMax;
        faimSlider.value = faimActuelle;

        energieSlider.maxValue = energieMax;
        energieSlider.value = energieActuelle;
    }

    void Update()
    {
        // Exemple de diminution de faim et �nergie
        faimActuelle -= Time.deltaTime * 1f; // Diminue la faim
        energieActuelle -= Time.deltaTime * 0.5f; // Diminue l'�nergie plus lentement

        faimActuelle = Mathf.Clamp(faimActuelle, 0, faimMax);
        energieActuelle = Mathf.Clamp(energieActuelle, 0, energieMax);

        faimSlider.value = faimActuelle;
        energieSlider.value = energieActuelle;

        // Ajoutez des cons�quences si faim ou �nergie sont � 0
    }
}
