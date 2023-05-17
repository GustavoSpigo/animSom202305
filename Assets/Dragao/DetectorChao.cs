using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorChao : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Chao dChao = col.GetComponent<Chao>();
        dChao.perna_dir.clip = dChao.passo_dir;
        dChao.perna_esq.clip = dChao.passo_esq;
    }
}
