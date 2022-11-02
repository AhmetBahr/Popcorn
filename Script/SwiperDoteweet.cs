using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiperDoteweet : MonoBehaviour
{

    public Transform pivot1;
    public Transform pivot2;
    public Transform pivot3;
    public Transform pivot4;

    float sayac;
    Sequence sequence;
    void Start()
    {
        //transform.DOShakeScale(1.1f, 0.5f, 5, 50).SetLoops(-1);

        
    }

    private void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            SwiperMove();
        }


    }





    void SwiperMove()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(pivot1.position, 4));
        sequence.Append(transform.DOMove(pivot2.position, 4f));
        sequence.Append(transform.DOMove(pivot3.position, 4f));
        sequence.Append(transform.DOMove(pivot4.position, 4));
    


    }


}
