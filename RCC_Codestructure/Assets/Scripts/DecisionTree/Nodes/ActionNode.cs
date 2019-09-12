using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Leaves of the Decision Tree - returns what action to take
/// </summary>
public class ActionNode : INode
{
    private Actor.ActionToTake actionToReturn =  Actor.ActionToTake.None;
        
    public ActionNode(Actor.ActionToTake actionToReturn)
    {
        this.actionToReturn = actionToReturn;
    }

    public Actor.ActionToTake Evaluate(Actor thinker)
    {
       return actionToReturn;
    }
}