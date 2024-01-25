using UnityEngine;
using TMPro;


public class Calculatrice : MonoBehaviour
{
    public TMP_InputField partieGaucheAddition;
    public TMP_InputField partieDroiteAddition;
    public TMP_Text resultatAddition;

    public TMP_InputField partieGaucheSoustraction;
    public TMP_InputField partieDroiteSoustraction;
    public TMP_Text resultatSoustraction;

    public TMP_InputField partieGaucheMultiplication;
    public TMP_InputField partieDroiteMultiplication;
    public TMP_Text resultatMultiplication;

    public TMP_InputField partieGaucheDivision;
    public TMP_InputField partieDroiteDivision;
    public TMP_Text resultatDivision;



    // Start is called before the first frame update
    void Start()
    {
    }

    public void FaireAddition()
    {
        int partieGauche;
        int partieDroite;
        int resultat;

        if (int.TryParse(partieGaucheAddition.text, out partieGauche) &&
            int.TryParse(partieDroiteAddition.text, out partieDroite))
        {
            resultat = partieGauche + partieDroite;
            resultatAddition.text = resultat.ToString();
        }
        else
        {
            partieGaucheAddition.text = "";
            partieDroiteAddition.text = "";
            resultatAddition.text = "?";
        }

    }

    public void FaireSoustraction()
    {
        int partieGauche;
        int partieDroite;
        int resultat;

        if (int.TryParse(partieGaucheSoustraction.text, out partieGauche) &&
            int.TryParse(partieDroiteSoustraction.text, out partieDroite))
        {
            resultat = partieGauche - partieDroite;
            resultatSoustraction.text = resultat.ToString();
        }
        else
        {
            partieGaucheSoustraction.text = "";
            partieDroiteSoustraction.text = "";
            resultatSoustraction.text = "?";
        }


    }

    public void FaireMultiplication()
    {
        int partieGauche;
        int partieDroite;
        int resultat;

        if (int.TryParse(partieGaucheMultiplication.text, out partieGauche) &&
            int.TryParse(partieDroiteMultiplication.text, out partieDroite))
        {
            resultat = partieGauche * partieDroite;
            resultatMultiplication.text = resultat.ToString();
        }
        else
        {
            partieGaucheMultiplication.text = "";
            partieDroiteMultiplication.text = "";
            resultatMultiplication.text = "?";
        }


    }

    public void FaireDivision()
    {
        int partieGauche;
        int partieDroite;
        int resultat;

        if (int.TryParse(partieGaucheDivision.text, out partieGauche) &&
            int.TryParse(partieDroiteDivision.text, out partieDroite) && partieDroite != 0)
        {
            resultat = partieGauche / partieDroite;
            resultatDivision.text = resultat.ToString();
        }
        else
        {
            partieGaucheDivision.text = "";
            partieDroiteDivision.text = "";
            resultatDivision.text = "?";
        }
    }
}
