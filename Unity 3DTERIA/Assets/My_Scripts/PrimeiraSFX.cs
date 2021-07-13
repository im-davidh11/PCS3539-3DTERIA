using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiraSFX : MonoBehaviour
{
    public AudioSource Pri_bum;

    public void Play1a()
    {
        Pri_bum.Play();
    }

    public void Play1mao()
    {
        Pri_bum.mute = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        //if (Input.GetMouseButtonDown(0))
        {
            Pri_bum.mute = false;
            Pri_bum.Play();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Pri_bum.mute = true;
        }
    }

}
