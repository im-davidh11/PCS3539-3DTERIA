using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anim_Surdo_Terceira : MonoBehaviour
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
            animator.SetTrigger("Baqueta_Terceira_Trigger");
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Mao_Terceira_Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}

