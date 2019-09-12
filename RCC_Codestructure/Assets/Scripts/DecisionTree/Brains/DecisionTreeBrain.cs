using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for Brains (that use Decision Trees)
/// </summary>
public class DecisionTreeBrain : MonoBehaviour, IActionPackageDeliverer
{
    [SerializeField] protected Actor actorType;
    private ActionPackage actionPackage;

    protected virtual void Awake()
    {
        actionPackage.AmAI = true;
    }

    public ActionPackage GetNextAction(Actor actor)
    {
        actionPackage.ActionToTake = Think(actor);

        return actionPackage;
    }

    public virtual Actor.ActionToTake Think(Actor actor)
    {
        throw new System.NotImplementedException("Using base class");
    }
}