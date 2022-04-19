using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Classe qui permet au joueur de bouger
 * Copie de l'exercice 3 sauf que la hauteur a été changée
 *
 * Auteurs: Enseignants de 420-1CB-BB
 */

public class MouvementJoueur : MonoBehaviour
{
    [SerializeField] private float vitesse = 2.0f; // Pour contrôler la vitesse de déplacement du cube
                                                   // La valeur par défaut est 2.0. Elle peut être modifiée dans l'inspecteuré
                                                   // ATTENTION: si la vitesse est de zéro, alors le cube ne bougera pas

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Lecture de la direction
        float horizontal = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionZ = transform.position.z + vertical;

        // On s'assure de rester dans les bornes du plan
        if (positionX >= -15 && positionX <= 15 && positionZ >= -15 && positionZ <= 15)
        {
            // Changement de la position du joueur
            // Ici, la position en y a été changée par rapport aux exercices 3 et 4
            transform.position = new Vector3(positionX, 0.5f, positionZ);
        }

    }
}
