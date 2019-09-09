using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Leaves of the Decision Tree - returns what action to take
/// </summary>
public class ActionNode : INode
{
    private Actor.Action actionToReturn =  Actor.Action.None;
        
    public ActionNode(Actor.Action actionToReturn)
    {
        this.actionToReturn = actionToReturn;
    }

    public Actor.Action Evaluate(Actor thinker)
    {
       return actionToReturn;
    }
}