using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

  


  

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.A))
        {
            fullPackage();
        
        }

    }

    public void fullPackage()
    {

        transform.DOMove(new Vector3(30, -1.95f, -3.5f), 10);

        OnDestroy();
    }


    public void Moveing()
    {

        transform.DOMove(new Vector3(0,-1.95f,-3.5f), 8);
    }



    private void OnDestroy()
    {
        Destroy(gameObject, 8);
    }

}
