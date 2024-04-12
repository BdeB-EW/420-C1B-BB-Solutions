using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CacherAfficher : MonoBehaviour
{
    [SerializeField] private Button bouton;
    [SerializeField] private GameObject panneau;

    public void CacherAfficherPanneau()
    {
        bool visible = panneau.activeSelf;
        visible = !visible;
        panneau.SetActive(visible);

        if (visible)
        {
            bouton.GetComponentInChildren<Text>().text = "Cacher";
        }
        else
        {
            bouton.GetComponentInChildren<Text>().text = "Afficher";
        }
    }
}
