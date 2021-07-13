using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anim_Surdo_Segunda : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        //if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Baqueta_Segunda_Trigger");
        }

       // if (Input.GetMouseButtonDown(1))
        //{
         //   animator.SetTrigger("AroTrigger");
        //}

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Mao_Segunda_Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

