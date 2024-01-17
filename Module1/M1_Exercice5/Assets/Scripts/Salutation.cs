using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salutation : MonoBehaviour
{
    public TMP_Text textSalutation;
    public string nom;
    public int age;

    // Start is called before the first frame update
    void Start()
    {
        textSalutation.text = "Bonjour " + nom + ", vous avez " + age + " ans.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
