using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * 
 * Programme qui illustre le fonctionnement d'un type int. Il est utilisé pour l'âge d'une personne
 * 
 * Auteurs: Enseignants de 420-C1B-BB
 */
public class SalutationAge : MonoBehaviour
{

    [SerializeField] private string nomPersonne;    // Le nom de la personne
    [SerializeField] private int age; // L'âge de la personne 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour " + nomPersonne + ", vous avez " + age + "ans.");

        // ou pour les braves:
        // Debug.Log($"Bonjour {nomPersonne}, vous avez {age} ans.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
