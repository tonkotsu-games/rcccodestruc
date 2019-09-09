using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for Brains (that use Decision Trees)
/// </summary>
public class DecisionTreeBrain : MonoBehaviour
{
    [SerializeField] protected Actor actor;

    public virtual Actor.Action Think()
    {
        throw new System.NotImplementedException("Using base class");
    }
}