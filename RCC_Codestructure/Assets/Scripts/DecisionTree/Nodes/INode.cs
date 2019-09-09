/// <summary>
/// Base Class for Decision Tree Nodes
/// </summary>
/// 
public interface INode
{
    Actor.Action Evaluate(Actor actor);
}