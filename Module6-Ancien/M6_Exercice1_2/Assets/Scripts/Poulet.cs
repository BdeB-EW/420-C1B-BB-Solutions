using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poulet : MonoBehaviour
{
    [SerializeField] private float vitesseMarche;
    [SerializeField] private float vitesseTourner;

    private Animator animationPoulet;
    private CharacterController controlleur;

    private AudioSource bruit;

    // Start is called before the first frame update
    void Start()
    {
        animationPoulet = GetComponent<Animator>();
        controlleur = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * vitesseMarche;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * vitesseMarche;

        Vector3 deplacement = new Vector3(horizontal, 0, vertical);
        deplacement = transform.TransformDirection(deplacement);
        controlleur.Move(deplacement);

        bool entreeAxeHorizontal = !Mathf.Approximately(horizontal, 0f);
        bool entreeAxeVertical = !Mathf.Approximately(vertical, 0f);

        if (entreeAxeHorizontal || entreeAxeVertical)
        {
            animationPoulet.SetBool("Walk", true);
        }
        else
        {
            animationPoulet.SetBool("Walk", false);
        }

        // On fait systématiquement descendre pour ne pas que l'objet marche dans le ciel
        Vector3 descendre = Vector3.down * 9.81f * Time.deltaTime;
        controlleur.Move(descendre);

        transform.Rotate(Vector3.up, horizontal * vitesseTourner);

        // Si le poulet mange
        if (Input.GetKey(KeyCode.Space))
        {
            animationPoulet.SetBool("Eat", true);
        }
        else
        {
            animationPoulet.SetBool("Eat", false);
        }
    }


    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject objetTouche = hit.gameObject;
        if (objetTouche.tag.Equals("Monstre"))
        {
            Destroy(objetTouche);
        }
    }
}
