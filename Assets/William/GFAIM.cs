using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class GFAIM : MonoBehaviour
    {
        public float faim = 100f; // La faim commence � 100%
        public float faimDecroissante = 1f; // Valeur de la r�duction de faim par seconde

        public void Update()
        {
            // R�duire la faim au fil du temps
            faim -= faimDecroissante * Time.deltaTime;

            // Limiter la faim entre 0 et 100
            faim = Mathf.Clamp(faim, 0f, 100f);
        }

        // M�thode pour augmenter la faim (par exemple, en mangeant de la nourriture)
        public void Manger(float quantite)
        {
            faim += quantite;
            faim = Mathf.Clamp(faim, 0f, 100f);
        }
    }

