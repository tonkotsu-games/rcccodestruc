﻿/// <summary>
/// Base Class for Decision Tree Nodes
/// </summary>
/// 
public interface INode
{
    Actor.ActionToTake Evaluate(Actor actor);
}