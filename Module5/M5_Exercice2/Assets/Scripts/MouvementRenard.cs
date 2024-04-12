using UnityEngine;

public class MouvementRenard : MonoBehaviour
{
    public float vitesse;
    public float vitesseRotation;

    private Animator _animator;
    private CharacterController _controleurMouvement;

    void Start()
    {
        _controleurMouvement = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;  // Ici, le temps est important pour la rotation

        if (vertical > 0)
        {
            Vector3 vecteurVitesse = transform.forward * vitesse * vertical;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                vecteurVitesse *= 2;
            }
            _controleurMouvement.SimpleMove(vecteurVitesse);
            _animator.SetBool("Marcher", true);
        }
        else
        {
            _animator.SetBool("Marcher", false);
        }

        if (vertical < 0)
        {
            _animator.SetBool("Assis", true);
        }
        else
        {
            _animator.SetBool("Assis", false);
        }

        if (!_animator.GetBool("Assis"))
        {
            transform.Rotate(Vector3.up, vitesseRotation * horizontal);

            if (vertical <= 0 && horizontal > 0)
            {
                _animator.SetBool("Droite", true);
            }
            else if (horizontal < 0)
            {
                _animator.SetBool("Gauche", true);
            }
            else
            {
                _animator.SetBool("Droite", false);
                _animator.SetBool("Gauche", false);
            }
        }
    }
}
