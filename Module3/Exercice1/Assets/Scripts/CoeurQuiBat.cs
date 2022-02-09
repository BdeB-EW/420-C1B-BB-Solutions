using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe qui fait grandir et rapetisser la sphère
/// 
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>
public class CoeurQuiBat : MonoBehaviour
{
    /// <summary>
    /// La vitesse de croissance et décroissance
    /// </summary>
    [SerializeField]
    private float vitesse;
    /// <summary>
    /// Un texte pour dire si on est en train d'agrandir ou de diminuer la taille
    /// </summary>
    [SerializeField]
    private Text textMessage;
    /// <summary>
    /// Permet de déterminer si on agrandit la sphère ou on la réduit
    /// </summary>
    private bool agrandissementActif;

    void Start()
    {
        agrandissementActif = true;
        textMessage.text = "Agrandissement";
        transform.localScale = Vector3.one * 2;
    }

    void Update()
    {
        // On agrandit ou on rapetisse selon la valeur du booléen
        if (agrandissementActif)
        {
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * vitesse;
        }
        else
        {
            transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * vitesse;
        }

        // On met à jour le booléen pour la prochaine itération
        if (transform.localScale.magnitude >= 8.0f)
        {
            agrandissementActif = false;
            textMessage.text = "Rétrécissement";
        }

        if (transform.localScale.magnitude <= 2.0f)
        {
            agrandissementActif = true;
            textMessage.text = "Agrandissement";
        }
    }
}
