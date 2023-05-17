using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragao : MonoBehaviour
{
    private Animator animator;
    public AudioSource pernaDireita;
    public AudioSource pernaEsquerda;
    public float velocidade;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("velocidade", Input.GetAxis("Horizontal"));

        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x) * -1f,
                transform.localScale.y,
                transform.localScale.z
            );
            transform.position = new Vector3(
                transform.position.x + (velocidade * Time.deltaTime),
                transform.position.y,
                transform.position.z
            );
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x),
                transform.localScale.y,
                transform.localScale.z
            );
            transform.position = new Vector3(
                transform.position.x - (velocidade * Time.deltaTime),
                transform.position.y,
                transform.position.z
            );
        }
        
    }

    public void tocaPassoDireito()
    {
        pernaDireita.volume = Random.Range(0.5f, 1f);
        pernaDireita.pitch = Random.Range(0.75f, 1.5f);
        pernaDireita.Play();
    }

    public void tocaPassoEsquerdo()
    {
        pernaEsquerda.volume = Random.Range(0.3f, 0.5f);
        pernaEsquerda.pitch = Random.Range(0.75f, 1.5f);
        pernaEsquerda.Play();
    }
}
