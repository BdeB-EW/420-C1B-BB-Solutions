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
        int partieGauche = int.Parse(partieGaucheAddition.text);
        int partieDroite = int.Parse(partieDroiteAddition.text);
        int resultat = partieGauche + partieDroite;
        resultatAddition.text = resultat.ToString();
    }

    public void FaireSoustraction()
    {
        int partieGauche = int.Parse(partieGaucheSoustraction.text);
        int partieDroite = int.Parse(partieDroiteSoustraction.text);
        int resultat = partieGauche - partieDroite;
        resultatSoustraction.text = resultat.ToString();
    }

    public void FaireMultiplication()
    {
        int partieGauche = int.Parse(partieGaucheMultiplication.text);
        int partieDroite = int.Parse(partieDroiteMultiplication.text);
        int resultat = partieGauche * partieDroite;
        resultatMultiplication.text = resultat.ToString();
    }

    public void FaireDivision()
    {
        int partieGauche = int.Parse(partieGaucheDivision.text);
        int partieDroite = int.Parse(partieDroiteDivision.text);
        int resultat = partieGauche / partieDroite;
        resultatDivision.text = resultat.ToString();
    }
}
