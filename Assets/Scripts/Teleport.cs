using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int level = 0;
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
            LoadScene(level);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        txt.text = "";
    }

    public void LoadScene (int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
