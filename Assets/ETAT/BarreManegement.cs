using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreManegement : MonoBehaviour
{
    public Slider faimSlider; // Première barre
    public Slider energieSlider; // Deuxième barre

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
        // Exemple de diminution de faim et énergie
        faimActuelle -= Time.deltaTime * 1f; // Diminue la faim
        energieActuelle -= Time.deltaTime * 0.5f; // Diminue l'énergie plus lentement

        faimActuelle = Mathf.Clamp(faimActuelle, 0, faimMax);
        energieActuelle = Mathf.Clamp(energieActuelle, 0, energieMax);

        faimSlider.value = faimActuelle;
        energieSlider.value = energieActuelle;

        // Ajoutez des conséquences si faim ou énergie sont à 0
    }
}
