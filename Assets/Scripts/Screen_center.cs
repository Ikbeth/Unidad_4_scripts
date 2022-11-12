using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_center : MonoBehaviour
{
    Vector3 sreenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f, 200f);

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(sreenCenter);
    }
}
