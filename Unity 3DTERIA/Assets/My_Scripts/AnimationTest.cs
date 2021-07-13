using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationTest : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.U))
        {
            animator.SetTrigger("BaquetaTrigger");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("AroTrigger");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("LeftTrigger");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }

    }
}

