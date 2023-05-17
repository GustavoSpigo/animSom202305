using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float pistaAtual = 0;
    public float distanciaLateral = 7.5f;
    public Transform fumaca;
    public Animator animFumaca;

    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            fumaca.position = new Vector3(
                transform.position.x,
                fumaca.position.y,
                fumaca.position.z
            );

            animFumaca.SetTrigger("fumaca");
            pistaAtual = Mathf.Min(distanciaLateral, pistaAtual + distanciaLateral);
        }else if(Input.GetKeyDown("left"))
        {
            fumaca.position = new Vector3(
                transform.position.x,
                fumaca.position.y,
                fumaca.position.z
            );

            animFumaca.SetTrigger("fumaca");
            pistaAtual = Mathf.Max(distanciaLateral * -1f, pistaAtual - distanciaLateral);
            
        }

        transform.position = new Vector3(
            pistaAtual ,
            transform.position.y,
            transform.position.z
        );
        
    }
}
