using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Script qui affiche les informations sur deux personnages.
 * 
 * Auteurs: Enseignants de 420-C1B-BB
 */
public class AfficherPersonnages : MonoBehaviour
{
    [SerializeField] private string nomPersonnage1; // nom du premier personnage
    [SerializeField] private string classePersonnage1; // classe du premier personnage
    [SerializeField] private int niveauPersonnage1; // niveau du premier personnage    
    [SerializeField] private int pointsDeViePersonnage1;  // points de vie du premier personnage
    
    [SerializeField] private string nomPersonnage2; // nom du deuxième personnage
    [SerializeField] private string classePersonnage2; // classe du deuxième personnage
    [SerializeField] private int niveauPersonnage2; // niveau du deuxième personnage
    [SerializeField] private int pointsDeViePersonnage2; // points de vie du premier personnage

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nomPersonnage1 + " " + classePersonnage1 + " de niveau " + niveauPersonnage1 + " PV: " + pointsDeViePersonnage1);
        Debug.Log(nomPersonnage2 + " " + classePersonnage2 + " de niveau " + niveauPersonnage2 + " PV: " + pointsDeViePersonnage2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
