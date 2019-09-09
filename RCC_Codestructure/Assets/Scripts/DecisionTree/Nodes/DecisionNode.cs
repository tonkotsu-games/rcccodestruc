using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionNode : INode
{

    private INode trueNode;
    private INode falseNode;

    public INode TrueNode { get => trueNode; set => trueNode = value; }
    public INode FalseNode { get => falseNode; set => falseNode = value; }

    public Actor.Action Evaluate(Actor actor)
    {

        if (TrueNode!=null && FalseNode!=null)
        {
            if (IsTrue(actor))
            {
                return TrueNode.Evaluate(actor);
            }
            else
            {
                return FalseNode.Evaluate(actor);
            }
        }
        else
        {
            throw new System.Exception( this.GetType().ToString() + ": " + (trueNode == null ? "TrueNode not Set" : "FalseNode not Set"));
        }
    }

    protected virtual bool IsTrue(Actor thinker)
    {
        throw new System.Exception("Calling unimplemented function DecisionNode.IsTrue()");
    }
}