using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Classe qui fait grandir et rapetisser la sphère
/// 
/// Auteurs: Enseignants de 420-1CB-BB
/// </summary>
public class Gonflement : MonoBehaviour
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
    private TMP_Text textMessage;
    /// <summary>
    /// Permet de déterminer si on agrandit la sphère ou on la réduit
    /// </summary>
    private bool gonflementActif;

    void Start()
    {
        gonflementActif = true;
        textMessage.text = "On gonfle";
        transform.localScale = Vector3.one * 2;
    }

    void Update()
    {
        // On agrandit ou on rapetisse selon la valeur du booléen
        if (gonflementActif)
        {
            transform.localScale += Vector3.one * Time.deltaTime * vitesse;
        }
        else
        {
            transform.localScale -= Vector3.one * Time.deltaTime * vitesse;
        }

        // On met à jour le booléen pour la prochaine itération
        if (transform.localScale.x >= 7.0f && transform.localScale.y >= 7.0f &&
            transform.localScale.z >= 7.0f)
        {
            gonflementActif = false;
            textMessage.text = "On dégonfle";
        }

        if (transform.localScale.x <= 2.0f && transform.localScale.y <= 2.0f &&
            transform.localScale.z <= 2.0f)
        {
            gonflementActif = true;
            textMessage.text = "On gonfle";
        }
    }
}
