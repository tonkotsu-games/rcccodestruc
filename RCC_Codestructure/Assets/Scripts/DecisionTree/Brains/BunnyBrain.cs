using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBrain : DecisionTreeBrain
{

    //Branches
    private PlayerInRangeNode playerInAggroRange = new  PlayerInRangeNode();
    private PlayerInRangeNode playerInMeleeRange = new PlayerInRangeNode();
    private ActorInActionNode actorInWalkToPlayerInAggro = new ActorInActionNode();
    private ActorInActionNode actorInWalkToPlayerOutAggro = new ActorInActionNode();

    //Leaves
    private ActionNode idleAction = new ActionNode( Actor.Action.Idle);
    private ActionNode attackAction = new ActionNode( Actor.Action.MeleeAttack);
    private ActionNode walkToPlayerAction = new ActionNode( Actor.Action.WalkTo);
    private ActionNode noAction = new ActionNode( Actor.Action.None);


    private void Awake()
    {

#region Nodes Setup

        // A1
        playerInAggroRange.TrueNode = playerInMeleeRange;
        playerInAggroRange.FalseNode = actorInWalkToPlayerOutAggro;
        playerInAggroRange.range = actor.AggroRange;

        // B1
        playerInMeleeRange.TrueNode = attackAction;
        playerInMeleeRange.FalseNode = actorInWalkToPlayerInAggro;
        playerInMeleeRange.range = actor.MeleeRange;

        // B2
        actorInWalkToPlayerOutAggro.TrueNode = idleAction;
        actorInWalkToPlayerOutAggro.FalseNode = noAction;
        actorInWalkToPlayerOutAggro.actionToTest =  Actor.Action.WalkTo;

        // C1
        actorInWalkToPlayerInAggro.TrueNode = noAction;
        actorInWalkToPlayerInAggro.FalseNode = walkToPlayerAction;
        actorInWalkToPlayerInAggro.actionToTest = Actor.Action.WalkTo;
#endregion
    }

    public override Actor.Action Think()
    {
        var result = playerInAggroRange.Evaluate(actor);
        return result;
    }
}
