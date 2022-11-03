using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform package;

    Sequence sequence;


    Package Referans_Kod1;


    public GameObject spawnpoint;
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            spawnPackage();
         
        }

    }

    public void spawnPackage()
    {
        Instantiate(package, spawnpoint.transform.position, Quaternion.identity);

        Referans_Kod1 = GameObject.Find("Package(Clone)").GetComponent<Package>();
        Referans_Kod1.Moveing();
    }





}
