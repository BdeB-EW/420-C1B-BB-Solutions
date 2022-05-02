using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactPoulet : MonoBehaviour
{
    private GameObject joueur;

    // Start is called before the first frame update
    void Start()
    {
        joueur = GameObject.Find("Joueur");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            Destroy(gameObject);
        }
    }
}
