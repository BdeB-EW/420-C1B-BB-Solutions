using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfficherTemps : MonoBehaviour
{
    [SerializeField] private Text textTemps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTemps.text = ((int) Time.realtimeSinceStartup).ToString();        
    }
}
