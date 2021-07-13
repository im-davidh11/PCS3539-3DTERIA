using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepiqueSFX : MonoBehaviour
{
    public AudioSource Repique_mid;
    public AudioSource Repique_int;
    public AudioSource Repique_rim;
    public AudioSource Repique_slp;

    public void PlayRm()
    {
        Repique_mid.Play();
    }

    public void PlayRi()
    {
        Repique_int.Play();
    }

    public void PlayRr()
    {
        Repique_rim.Play();
    }

    public void PlayRs()
    {
        Repique_slp.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Repique_mid.Play();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Repique_int.Play();
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            Repique_rim.Play();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Repique_slp.Play();
        }
    }

}