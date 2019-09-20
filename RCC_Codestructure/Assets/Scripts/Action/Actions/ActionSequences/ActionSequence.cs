using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSequence : IAction
{
    IAction[] actionsToDo = null;
    private int index;

    public virtual void Enter()
    {
        index = 0;
        actionsToDo[index].Enter();
    }

    public virtual void Execute()
    {
        if (index >= actionsToDo.Length)
            return;

        actionsToDo[index].Execute();

        if (actionsToDo[index].IsDone())
        {
            index += 1;
            if (index < actionsToDo.Length)
                actionsToDo[index].Enter();
        }
    }

    public virtual void Exit()
    {
        throw new System.NotImplementedException();
    }

    public bool IsDone()
    {
        return index >= actionsToDo.Length;
    }
}
