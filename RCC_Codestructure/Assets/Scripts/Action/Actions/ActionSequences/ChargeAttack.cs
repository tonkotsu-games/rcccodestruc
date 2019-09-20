using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeAttack : ActionSequence
{
    IAction[] actionsToDo = null;
    private Actor actor;

    public ChargeAttack(Actor actor)
    {
        IAction[] actions = new IAction[]
           {
                new WalkTo(),
                new MeleeAttack()
           };

        this.actor = actor;
    }
}
