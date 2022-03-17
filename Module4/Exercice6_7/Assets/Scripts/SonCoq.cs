using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonCoq : MonoBehaviour
{
    private AudioSource cocorico;

    // Start is called before the first frame update
    void Start()
    {
        cocorico = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cocorico.Play();
        }
    }
}
