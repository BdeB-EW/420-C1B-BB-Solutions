using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Programme qui salue une personne dont le nom est contenu dans une variable.
 * 
 * Auteurs: Enseignants de 420-C1B-BB
 */
public class SalutationPersonne : MonoBehaviour
{
    [SerializeField] private string nomPersonne; // La personne à saluer. [SerializeField] permet d'assigner une valeur dans l'interface de Unity

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bonjour " + nomPersonne);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
