using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageSalutation : MonoBehaviour
{

    public TMP_Text txtMessage;

    // Start is called before the first frame update
    void Start()
    {
        txtMessage.text = "Ma première interface !";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
