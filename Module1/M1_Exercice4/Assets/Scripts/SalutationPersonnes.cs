using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SalutationPersonnes : MonoBehaviour
{
    public TMP_Text messageSalutation;
    public string nomPersonne;
    
    // Start is called before the first frame update
    void Start()
    {
        messageSalutation.text = "Bonjour " + nomPersonne;
    }
}
