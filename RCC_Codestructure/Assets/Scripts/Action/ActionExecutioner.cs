using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionExecutioner
{
    private IAction currentAction;
    private IAction previousAction;
    private bool paused = false;

    public IAction CurrentAction { get => currentAction; private set => currentAction = value; }

    public void ChangeState(IAction newAction)
    {
        if(CurrentAction != null)
        {
            CurrentAction.Exit();
        }

        previousAction = CurrentAction;
        CurrentAction = newAction;
        CurrentAction.Enter();
    }

    public void ActionExecuteTick()
    {
        if(CurrentAction != null && !paused)
        {
            CurrentAction.Execute();
        }
    }

    public void ReturnToPreviousAction()
    {
        CurrentAction = previousAction;
    }

    public void TogglePause()
    {
        paused = !paused;
    }

    public void TryStun()
    {
        //Fill in here
        //Check if it is IStunnable
        //if it is use its Try Stun function
    }
}