using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCube : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == joueur)
        {
            Destroy(gameObject);
        }
    }
}
