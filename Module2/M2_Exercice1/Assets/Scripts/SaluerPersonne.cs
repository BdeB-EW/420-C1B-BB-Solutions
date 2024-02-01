using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaluerPersonne : MonoBehaviour
{
    public TMP_Text textNom;
    public Button boutonDireBonjour;
    public TMP_InputField champSaisieNom;
    public TMP_Text texteSalutation;

    void Start()
    {
        texteSalutation.gameObject.SetActive(false);
    }

public void DireBonjour()
    {
        texteSalutation.text = "Bonjour " + champSaisieNom.text;

        textNom.gameObject.SetActive(false);
        boutonDireBonjour.gameObject.SetActive(false);
        champSaisieNom.gameObject.SetActive(false);
        texteSalutation.gameObject.SetActive(true);
    }
}
