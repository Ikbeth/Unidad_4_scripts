using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Take_Object : MonoBehaviour
{
    public TextMeshProUGUI txt;

    // Update is called once per frame
    void Start()
    {
        txt.text = "";
    }

    public void OnTriggerEnter(Collider other)
    {
        txt.text = "press f to pick up";

        if (Input.GetKeyDown(KeyCode.F))
        {
            take();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        txt.text = "";
    }

    public void take()
    {

    }
}
