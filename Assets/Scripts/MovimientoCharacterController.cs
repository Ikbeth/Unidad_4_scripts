using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCharacterController : MonoBehaviour
{
    [SerializeField]
    CharacterController cc;

    [SerializeField]
    float velocidad; //velocidad de movimiento

    [SerializeField]
    float gravedad = -9.81f;

    [SerializeField]
    float alto_salto = 1f;

    [SerializeField]
    Vector3 velocidadJugador; //velocidad de caida

    bool enPiso;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        enPiso = cc.isGrounded;
        if (enPiso && velocidadJugador.y<0)
        {
            velocidadJugador.y = -2f;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 v_movimiento_personaje = transform.right * horizontal + transform.forward * vertical;
        v_movimiento_personaje *= velocidad;
       
        cc.Move(v_movimiento_personaje*Time.deltaTime);

        if (Input.GetButtonDown("Jump") && enPiso) {
            velocidadJugador.y += Mathf.Sqrt(alto_salto * -3.0f * gravedad);
        }
        
        velocidadJugador.y += gravedad * Time.deltaTime;
        cc.Move(velocidadJugador * Time.deltaTime);

    }
}
