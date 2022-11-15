using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    private void OnTriggerStay(Collider other)
    {
        txt.text = "press c";

        if (Input.GetKey(KeyCode.C))
        {
            LoadScene();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        txt.text = "";
    }

    public void LoadScene ()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (!scene.Equals(1))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
