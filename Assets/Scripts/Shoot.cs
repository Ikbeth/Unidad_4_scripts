using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float range = 1500f;
    public float damage = 10f;
    public float shootRate = 0.5f;
    private float shootRateTime = 0;

    RaycastHit hit;

    public Camera cam;
    public GameObject spawn;
    // Update is called once per frame
    void Update()
    {
        //crear bala al presionaar clic izq
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shootRateTime)
            {
                if (Physics.Raycast(spawn.transform.position, cam.transform.forward, out hit, range))
                {
                    Debug.Log(hit.transform.name);
                }

                //a~ade el tiempo de cooldown para disparar
                shootRateTime = Time.time + shootRate;
            }
            
        }
    }
}
