using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreManegement : MonoBehaviour
{
    public Slider hungerSlider; // Première barre
    public Slider thirstSlider; // Deuxième barre

    public float hungerMax = 100f;
    public float thirstMax = 100f;

    private float hungerActuelle;
    private float thirstActuelle;

    void Start()
    {
        hungerActuelle = hungerMax;
        thirstActuelle = thirstMax;

        hungerSlider.maxValue = hungerMax;
        hungerSlider.value = hungerActuelle;

        thirstSlider.maxValue = thirstMax;
        thirstSlider.value = thirstActuelle;

        //permet de mettre au depart la barre de faim et soif à son état max donc 100%
    }

    void Update()
    {
        // Exemple de diminution de faim et énergie
        hungerActuelle -= Time.deltaTime * 1f; // Diminue la faim
        thirstActuelle -= Time.deltaTime * 0.5f; // Diminue l'énergie plus lentement

        hungerActuelle = Mathf.Clamp(hungerActuelle, 0, hungerMax);
        thirstActuelle = Mathf.Clamp(thirstActuelle, 0, thirstMax);

        hungerSlider.value = hungerActuelle;
        thirstSlider.value = thirstActuelle;

        // Ajoutez des conséquences si faim ou énergie sont à 0
    }
}
