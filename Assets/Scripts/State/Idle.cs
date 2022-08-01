using System;
using System.Collections.Generic;
using UnityEngine;


public class Idle : State
{
    Transition transitiontest;

    public override void Awake()
    {

        transitiontest = new Transition();
        transitiontest.condition = new ConditionToChase();

        transitions.Add(transitiontest);
    }
    public override void OnEnable()
    {
        GameObject Obj = GameObject.FindWithTag("Enemy");

        Renderer Objcolor = Obj.GetComponent<Renderer>();

        Objcolor.material.color = Color.gray;

    }


    public override void Update()
    {
        Debug.Log("플레이어가 탐지되지 않았습니다!");
    }
}
