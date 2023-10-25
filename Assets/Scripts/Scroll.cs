using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Scroll : MonoBehaviour
{
    
    public GameObject[] backgrounds;
    private float scrollSpeed = 0.22f;
    private bool rotate;


    private void Start()
    {
        rotate = true;
    }

    private void Update()
    {
        
        for(int background = 0; background < backgrounds.Length; background++)
        {

                Renderer rend = backgrounds[background].GetComponent<Renderer>();
                float offset = Time.time * scrollSpeed ;
                rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }

        if (rotate == true && Input.GetKeyDown(KeyCode.Space))
        {
            
            scrollSpeed = -0.22f;
            rotate = false;
        }

         

        else if (rotate == false && Input.GetKeyDown(KeyCode.Space))     
        {
            
            scrollSpeed = 0.22f;
            rotate = true;
        }
       
    }
   
    
}

