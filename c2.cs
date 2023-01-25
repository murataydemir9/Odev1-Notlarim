using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class c2 : MonoBehaviour
        
{
    private void Update()
    {

        if (transform.localRotation.z == 90) ;

    }

    private void OnMouseDown()
    {
        
        
            transform.DORotate(new Vector3(0, 0, +90), 0.2f, RotateMode.WorldAxisAdd);
        
    }





   

}

