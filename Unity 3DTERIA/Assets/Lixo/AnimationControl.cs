using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    public GameObject Baqueta;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Ta"))
        {
            Baqueta.GetComponent<Animation>().Play("Baqueta_Animation");
        }
    }
}
