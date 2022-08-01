using System;
using System.Collections.Generic;
using UnityEngine;


public class Chase : State
{
    Transition transitiontest;

    GameObject Obj;
    GameObject PlayerObj;
    public override void Awake()
    {
        transitiontest = new Transition();
        transitiontest.condition = new ConditionToIdle();

        transitions.Add(transitiontest);
    }
    public override void OnEnable()
    {
        Obj = GameObject.FindWithTag("Enemy");
        PlayerObj = GameObject.FindWithTag("Player");

        Renderer Objcolor = Obj.GetComponent<Renderer>();

        Objcolor.material.color = Color.red;
    }
    public override void Update()
    {
        Debug.Log("플레이어를 쫓아라!");

        Vector3 dir = PlayerObj.transform.position - Obj.transform.position;
        Obj.transform.Translate(dir.normalized * 3.0f * Time.deltaTime);
    }
}
