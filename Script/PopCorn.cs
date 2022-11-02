using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopCorn : MonoBehaviour
{
    Manager_Gecici Referans_Kod1;

    private void Start()
    {
        Referans_Kod1 = GameObject.Find("Managers").GetComponent<Manager_Gecici>();


    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Scored");
        Referans_Kod1.scoreUp();
    }


}
