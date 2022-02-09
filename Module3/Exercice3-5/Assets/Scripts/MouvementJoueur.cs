using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Classe qui permet au joueur de bouger
///  
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>

public class MouvementJoueur : MonoBehaviour
{
    /// <summary>
    /// Pour contrôler la vitesse de déplacement du cube
    /// La valeur par défaut est 2.0. Elle peut être modifiée dans l'inspecteur
    /// ATTENTION: si la vitesse est de zéro, alors le cube ne bougera pas
    /// </summary>
    [SerializeField] private float vitesse = 2.0f;
    /// <summary>
    /// La vitesse de rotation
    /// </summary>
    [SerializeField] private float vitesseRotation;

    void Start()
    {

    }

    void Update()
    {
        // Lecture de la direction et ajustement avec le forward
        float horizontal = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;
        Vector3 deplacement = new Vector3(horizontal, 0, vertical);
        deplacement = transform.TransformDirection(deplacement);

        // Calcul des nouvelles positions
        float positionX = transform.position.x + deplacement.x;
        float positionZ = transform.position.z + deplacement.z;

        // On s'assure de rester dans les bornes du plan
        if (positionX >= -15 && positionX <= 15 && positionZ >= -15 && positionZ <= 15)
        {
            // Changement de la position du joueur
            transform.position = new Vector3(positionX, 0.5f, positionZ);
        }

        if (Input.GetKey(KeyCode.X))
        {
            float angle = vitesseRotation * Time.deltaTime;
            transform.Rotate(Vector3.up, angle);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            float angle = vitesseRotation * Time.deltaTime;
            transform.Rotate(Vector3.up, -angle);
        }
    }
}
