using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInActionNode : DecisionNode
{
    public Actor.ActionToTake actionToTest = (Actor.ActionToTake) (-1);

    protected override bool IsTrue(Actor actor)
    {
        if ((int) actionToTest == -1)
        {
            throw new System.Exception("action not set up in DecisionNode.IsTrue()?");
        }
        else if (actor.currentAction == actionToTest)
        {
            return true;
        }
        return false;
    }
}
