using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poulet : MonoBehaviour
{
    [SerializeField] private float vitesseMarche;
    [SerializeField] private float vitesseTourner;

    private Animator animationPoulet;

    // Start is called before the first frame update
    void Start()
    {
        animationPoulet = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(Vector3.forward * vertical * vitesseMarche);
        transform.Rotate(Vector3.up, horizontal * vitesseTourner);

        bool entreeAxeHorizontal = ! Mathf.Approximately(horizontal, 0f);
        bool entreeAxeVertical = ! Mathf.Approximately(vertical, 0f);

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
