using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DevinetteNombre : MonoBehaviour
{
    public TMP_Text textNombreEssais;
    public TMP_InputField inputNombre;
    public TMP_Text textResultat;

    public Button boutonSoumettre;
    public Button boutonNouvellePartie;

    // Variables qu'on ne veut pas voir dans l'inspecteur
    private int nombreEssais;
    private int nombreAleatoire;


    // Start is called before the first frame update
    void Start()
    {
        NouvellePartie();
    }

    // Update is called once per frame
    void Update()
    {
        textNombreEssais.text = "Il vous reste " + nombreEssais + " essai(s)";

        //if (nombreEssais <= 0)
        //{
        //    textResultat.text = "Vous avez perdu! Le nombre était " + nombreAleatoire;
        //    boutonSoumettre.gameObject.SetActive(false);
        //    boutonNouvellePartie.gameObject.SetActive(true);
        //}
    }

    public void SoumettreNombre()
    {
        int nombre;
        if (int.TryParse(inputNombre.text, out nombre))
        {
            if (nombre == nombreAleatoire)
            {
                textResultat.text = "Vous avez gagné!";
                boutonSoumettre.gameObject.SetActive(false);
                boutonNouvellePartie.gameObject.SetActive(true);
            }
            else if (nombre < nombreAleatoire)
            {
                textResultat.text = "Votre essai est trop petit";
            }
            else
            {
                textResultat.text = "Votre essai est trop grand";
            }
            nombreEssais--;
        }
        inputNombre.text = "";
    }

    public void NouvellePartie()
    {
        nombreEssais = 10;
        nombreAleatoire = Random.Range(1, 1001);
        boutonSoumettre.gameObject.SetActive(true);
        boutonNouvellePartie.gameObject.SetActive(false);
        textResultat.text = "";
    }
}
