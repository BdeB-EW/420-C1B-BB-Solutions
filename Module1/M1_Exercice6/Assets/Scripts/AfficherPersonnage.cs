using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Script qui affiche les informations sur un personnage.
 * 
 * Auteurs: Enseignants de 420-C1B-BB
 */
public class AfficherPersonnage : MonoBehaviour
{
    [SerializeField] private string nomPersonnage; // nom du personnage
    [SerializeField] private string classePersonnage; // classe du personnage
    [SerializeField] private int niveauPersonnage; // niveau du personnage    
    [SerializeField] private int pointsDeViePersonnage;  // points de vie du personnage
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nomPersonnage + " " + classePersonnage + " de niveau " + niveauPersonnage + " PV: " + pointsDeViePersonnage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
