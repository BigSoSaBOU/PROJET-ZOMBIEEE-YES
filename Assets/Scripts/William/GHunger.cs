using UnityEngine;




public class GHunger : MonoBehaviour
    {
        public float hunger = 100f; // La faim commence à 100%
        public float hungerDecroissante = 1f; // Valeur de la réduction de faim par seconde

        public void Update()
        {
            // Réduire la faim au fil du temps
            hunger -= hungerDecroissante * Time.deltaTime;

            // Limiter la faim entre 0 et 100
            hunger = Mathf.Clamp(hunger, 0f, 100f);
        }

        // Méthode pour augmenter la faim (par exemple, en mangeant de la nourriture)
        public void Manger(float quantite)
        {
            hunger += quantite;
            hunger = Mathf.Clamp(hunger, 0f, 100f);
        }
    }

