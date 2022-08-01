using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private List<State> Statelist;
    private State curState;

    void Start()
    {
        Statelist = new List<State>();

        State sIdle = new Idle();
        State sChase = new Chase();

        Statelist.Add(sIdle);
        Statelist.Add(sChase);



        foreach (State s in Statelist)
        {
            s.Awake();
        }

        sIdle.transitions[0].target = sChase;
        sChase.transitions[0].target = sIdle;

        curState = Statelist[0];

    }

    // Update is called once per frame
    void Update()
    {
        curState.Update();

    }

    void LateUpdate()
    {
        foreach (Transition t in curState.transitions)
        {
            if (t.condition.Test())
            {
                curState = t.target;
                curState.OnEnable();
                return;
            }
        }
    }
}


