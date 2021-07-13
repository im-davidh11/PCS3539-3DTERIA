using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundaSFX : MonoBehaviour
{
    public AudioSource Seg_dao;

    public void Play2a()
    {
        Seg_dao.Play();
    }

    public void Play2mao()
    {
        Seg_dao.mute = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        //if (Input.GetMouseButtonDown(0))
        {
            Seg_dao.mute = false;
            Seg_dao.Play();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Seg_dao.mute = true;
        }
    }

}