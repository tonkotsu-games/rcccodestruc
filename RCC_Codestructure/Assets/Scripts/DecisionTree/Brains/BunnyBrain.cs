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
    private ActionNode idleAction = new ActionNode( Actor.ActionToTake.Idle);
    private ActionNode attackAction = new ActionNode( Actor.ActionToTake.MeleeAttack);
    private ActionNode walkToPlayerAction = new ActionNode( Actor.ActionToTake.WalkTo);
    private ActionNode noAction = new ActionNode( Actor.ActionToTake.None);


    protected override void Awake()
    {
        base.Awake();

#region Nodes Setup

        // A1
        playerInAggroRange.TrueNode = playerInMeleeRange;
        playerInAggroRange.FalseNode = actorInWalkToPlayerOutAggro;
        playerInAggroRange.range = actorType.AggroRange;

        // B1
        playerInMeleeRange.TrueNode = attackAction;
        playerInMeleeRange.FalseNode = actorInWalkToPlayerInAggro;
        playerInMeleeRange.range = actorType.MeleeRange;

        // B2
        actorInWalkToPlayerOutAggro.TrueNode = idleAction;
        actorInWalkToPlayerOutAggro.FalseNode = noAction;
        actorInWalkToPlayerOutAggro.actionToTest =  Actor.ActionToTake.WalkTo;

        // C1
        actorInWalkToPlayerInAggro.TrueNode = noAction;
        actorInWalkToPlayerInAggro.FalseNode = walkToPlayerAction;
        actorInWalkToPlayerInAggro.actionToTest = Actor.ActionToTake.WalkTo;
#endregion
    }

    public override Actor.ActionToTake Think(Actor actor)
    {
        var result = playerInAggroRange.Evaluate(actor);
        return result;
    }
}
