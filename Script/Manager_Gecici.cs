using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Gecici : MonoBehaviour
{

    int Score = 0;

    private void Start()
    {
        Score = 0;
    }


    private void Update()
    {
      
    }


    public void scoreUp()
    {
        Score++;
        Debug.Log(Score);
    } 






}
