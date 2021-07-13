using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaSFX : MonoBehaviour
{
    public AudioSource Caixa_dir;
    public AudioSource Caixa_esq;
    public AudioSource Caixa_ruf;

    public void PlayCaixad()
    {
        Caixa_dir.Play();
    }

    public void PlayCaixae()
    {
        Caixa_esq.Play();
    }

    public void PlayCaixar()
    {
        Caixa_ruf.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Caixa_dir.Play();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Caixa_esq.Play();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Caixa_ruf.Play();
        }
    }

}
