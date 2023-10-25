using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
        }


    }
}