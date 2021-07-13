using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerceiraSFX : MonoBehaviour
{
    public AudioSource Ter;

    public void Play3a()
    {
        Ter.Play();
    }

    public void Play3mao()
    {
        Ter.mute = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        //if (Input.GetMouseButtonDown(0))
        {
            Ter.mute = false;
            Ter.Play();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Ter.mute = true;
        }
    }

}
