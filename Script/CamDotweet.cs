using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDotweet : MonoBehaviour
{

    public Transform pivot1;
    public Transform pivot2;


    float sayac;
    Sequence sequence;
    void Start()
    { }

    private void Update()
    {

      /*  if (Input.GetMouseButtonDown(0))
        {
            SwiperMove();
        }*/


    }
    public void CamMoveUp()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(pivot1.position, 4)).OnComplete(() => StartCoroutine(wait2sec()));

    }

    public void CamMoveDown()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(pivot2.position, 4f));

    }

    IEnumerator wait2sec()
    {

        yield return new WaitForSeconds(6f);
        CamMoveDown();
    }

}
