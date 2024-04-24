using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementObjet : MonoBehaviour
{
    private int boutonClique;

    public void Start()
    {
        boutonClique = -1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            boutonClique = 0;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            boutonClique = 1;
        }
        else
        {
            boutonClique = -1;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Allo: " + boutonClique);
        if (boutonClique == 0)
        {
            transform.position += Vector3.up;
        }
        else if (boutonClique == 1)
        {
            transform.position += Vector3.down;
        }
    }
}
