using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poulet : MonoBehaviour
{
    [SerializeField] private float vitesseMarche;
    [SerializeField] private float vitesseTourner;

    private Animator animationPoulet;

    private AudioSource bruit;

    // Start is called before the first frame update
    void Start()
    {
        animationPoulet = GetComponent<Animator>();
    }
    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        BougerPoulet(horizontal, vertical);
        DeterminerAnimation(horizontal, vertical);
    }

    private void BougerPoulet(float mouvementHorizontal, float mouvementVertical)
    {
        transform.Translate(Vector3.forward * mouvementVertical * vitesseMarche);
        transform.Rotate(Vector3.up, mouvementHorizontal * vitesseTourner);
    }

    private void DeterminerAnimation(float mouvementHorizontal, float mouvementVertical)
    {
        bool entreeAxeHorizontal = !Mathf.Approximately(mouvementHorizontal, 0f);
        bool entreeAxeVertical = !Mathf.Approximately(mouvementVertical, 0f);

        if (entreeAxeHorizontal || entreeAxeVertical)
        {
            animationPoulet.SetBool("Walk", true);
        }
        else
        {
            animationPoulet.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animationPoulet.SetBool("Eat", true);
        }
        else
        {
            animationPoulet.SetBool("Eat", false);
        }
    }
}
