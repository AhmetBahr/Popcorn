using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiperDoteweet : MonoBehaviour
{

    public Transform pivot1;
    public Transform pivot2;
    public Transform pivot3;
    //  public Transform pivot4;

    ThingDoteweet ReferansKod1;
    CamDotweet ReferansKod2;
    Package ReferansKod3;

    Sequence sequence;
    void Start()
    {
        ReferansKod1 = GameObject.Find("Slide").GetComponent<ThingDoteweet>();
        ReferansKod2 = GameObject.Find("Main Camera").GetComponent<CamDotweet>();
        ReferansKod3 = GameObject.Find("Popcorn Box Prefab").GetComponent<Package>();

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SwiperMove();
            ReferansKod1.SwiperMoveUP();
            ReferansKod2.CamMoveUp();
            ReferansKod3.Moveing();
        }


    }
    void SwiperMove()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(pivot1.position, 2.5f));
        sequence.Append(transform.DOMove(pivot2.position, 2.5f));
        sequence.Append(transform.DOMove(pivot3.position, 5f));
      
    }

    IEnumerator wait2sec()
    {

        yield return new WaitForSeconds(3f);
    }



}
