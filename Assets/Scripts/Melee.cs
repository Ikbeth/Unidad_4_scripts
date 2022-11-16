using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public float range = 10f;
    public float damage = 10f;
    public float shootRate = 1f;
    private float shootRateTime = 0;

    RaycastHit hit;

    public Camera cam;

    public GameObject impact;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shootRateTime)
            {
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
                {
                    Debug.Log(hit.transform.name);

                    GameObject ImpactGO = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(ImpactGO, 2f);
                }

                //a~ade el tiempo de cooldown para disparar
                shootRateTime = Time.time + shootRate;
            }

        }
    }
}
