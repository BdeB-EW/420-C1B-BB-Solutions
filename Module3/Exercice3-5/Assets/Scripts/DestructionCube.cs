using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe qui détruit l'objet s'il entre en contact avec le joueur
/// 
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>
public class DestructionCube : MonoBehaviour
{
    /// <summary>
    /// Le joueur qui entre en contact avec le cube.
    /// On devra vérifier que c'est cet objet qui entre en contact avec le cube
    /// </summary>
    private GameObject joueur;

    void Start()
    {
        // Permet d'obtenir l'objet ayant le nom Joueur
        joueur = GameObject.Find("Joueur");    
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Détruit l'objet s'il est en contact avec le joueur
        if (other.gameObject == joueur)
        {
            Destroy(gameObject);
        }
    }
}
