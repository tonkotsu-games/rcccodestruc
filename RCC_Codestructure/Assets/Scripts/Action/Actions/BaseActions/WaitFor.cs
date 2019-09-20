using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitFor : IAction
{
    private float waitTime;
    private Timer waitTimer;

    public WaitFor(float waitTime)
    {
        this.waitTime = waitTime;
    }

    public void Enter()
    {
        waitTimer =  new Timer(waitTime);
    }

    public void Execute()
    {
        waitTimer.Tick();
    }

    public void Exit()
    {
   
    }

    public bool IsDone()
    {
        if (waitTimer.timeCurrent <= 0)
        {
            return false;
        }
        return true;
    }
}
