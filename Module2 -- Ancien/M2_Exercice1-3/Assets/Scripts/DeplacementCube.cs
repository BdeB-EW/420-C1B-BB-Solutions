using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Classe qui déplace le cube en fonction des entrées des utilisateurs.
 * 
 * Auteurs: Enseignants du cours de 420-C1B-BB
 * 
 */
public class DeplacementCube : MonoBehaviour
{
    [SerializeField]
    private float vitesseDeplacement;  // Pour la vitesse de déplacement

    // Update is called once per frame
    void Update()
    {
        // Lecture du déplacement selon les axes
        float horizontal = Input.GetAxis("Horizontal") * vitesseDeplacement * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesseDeplacement * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionY = transform.position.y; // On ne change pas la hauteur
        float positionZ = transform.position.z + vertical;

        // Changement de la position du joueur
        transform.position = new Vector3(positionX, positionY, positionZ);        
    }
}
