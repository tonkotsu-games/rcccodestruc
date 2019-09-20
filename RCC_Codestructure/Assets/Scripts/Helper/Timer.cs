using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{

    public float timeCurrent = 0;
    public float timeMax = 0;
    public bool paused = false;

    public Timer(float maxTime)
    {
        timeMax = maxTime;
    }

    public void Tick()
    {
        if(!paused)
        {
            timeCurrent -= Time.deltaTime;
        }
    }
    
    public void RestartTimer()
    {
        timeCurrent = timeMax;
        paused = false;
    }

    public void Pause()
    {
        paused = true;
    }

    public void Unpause()
    {
        paused = false;
    }
}