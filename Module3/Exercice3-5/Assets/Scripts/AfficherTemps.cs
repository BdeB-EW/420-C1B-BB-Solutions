using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe qui affiche le temps depuis le démarrage du jeu dans un champ texte
/// 
/// Auteurs: Enseignants de 420-C1B-BB
/// </summary>
public class AfficherTemps : MonoBehaviour
{
    /// <summary>
    /// Le texte pour écrire le temps
    /// </summary>
    [SerializeField] private Text textTemps;

    void Start()
    {
        
    }

    void Update()
    {
        // Conversion du temps qui est un float en entier.
        // Tronque la partie décimale. Par exemple (int) 5.99 devient 5.
        textTemps.text = ((int) Time.realtimeSinceStartup).ToString();
    }
}
