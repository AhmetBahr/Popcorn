using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

    void Update()
    {
    /*    if (Input.GetMouseButtonDown(0))
        {
            Moveing();

        }
    */
    }

 

    public void Moveing()
    {

        transform.DOMove(new Vector3(0, -2.75f, -7.15f), 4).OnComplete(() => StartCoroutine(wait2sec()));

    }

    public void fullPackage()
    {
        transform.DOMove(new Vector3(11, -2.75f, -7.15f), 4).OnComplete(() => BackToPosition());

    }


    private void BackToPosition()
    {
        transform.position = new Vector3(-12, -2.75f, -7.15f);

        GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, 0);

    }

    IEnumerator wait2sec()
    {

        yield return new WaitForSeconds(7f);
        fullPackage();
    }

}
