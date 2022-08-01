using System;
using System.Collections.Generic;
using UnityEngine;


public class ConditionToChase : Condition
{
    GameObject targetObj = GameObject.FindWithTag("Player");
    GameObject originObj = GameObject.FindWithTag("Enemy");

    float findDis = 5f;
    float dis;
    public override bool Test()
    {
        dis = Vector3.Distance(targetObj.transform.position, originObj.transform.position);

        if (dis <= findDis)
            return true;
        else 
            return false;

    }
}
