using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRenard : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();
        bool marcher = Input.GetKey(KeyCode.Space);
        animator.SetBool("Marcher", marcher);
    }
}
