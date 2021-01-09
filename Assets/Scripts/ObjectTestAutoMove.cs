using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  ObjectTestAutoMove: MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {

        StartMoving();

    }

    void StartMoving()
    {
        float targetY = transform.position.y > 0 ? -10 : 10;
        

        Vector3 target = new Vector3(transform.position.x, targetY, transform.position.z);
        transform.DOMove(target, 2f).SetEase(Ease.OutCubic).OnComplete(StartMoving);
    }


    bool movingDown = true;

    void Update()
    {



       
        
        

     
    }
}
