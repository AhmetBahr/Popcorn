using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

  


    void Start()
    {
        
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.A))
        {
            fullPackage();
        
        }

    }

    public void fullPackage()
    {

        transform.DOMove(new Vector3(30, -1.95f, -3.5f), 15);


    }


    public void Moveing()
    {

        transform.DOMove(new Vector3(0,-1.95f,-3.5f), 8);
    }



}
