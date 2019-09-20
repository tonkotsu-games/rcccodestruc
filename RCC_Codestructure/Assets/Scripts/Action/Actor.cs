using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float aggroRange = 20f;
    [SerializeField] private float meleeRange = 3f;
    [SerializeField] private bool think = false;

    [SerializeField] private BunnyBrain bunnyBrain = null;

    private ActionExecutioner actionExecutioner = new ActionExecutioner();

    public ActionToTake currentAction;

    public GameObject Player { get => player; set => player = value; }
    public float AggroRange { get => aggroRange; }
    public float MeleeRange { get => meleeRange; }
    public ActionExecutioner ActionExecutioner { get => actionExecutioner;}

    protected void Update()
    {
        if(think)
        {
            ActionToTake result = bunnyBrain.Think(this);

            if (result != ActionToTake.None)
            {
                currentAction = result;
            }

            switch (result)
            {
                case ActionToTake.MeleeAttack:
                    MeleeAttack();
                    break;

                case ActionToTake.Idle:
                    Idle();
                    break;

                case ActionToTake.WalkTo:
                    WalkTo();
                    break;
            }
           
            
        }
        else
        {
            actionExecutioner.ActionExecuteTick();
        }

    }

    //Action Implementation
    
    protected virtual void MeleeAttack()
    {
        throw new System.Exception("Calling Actor base method MeleeAttack");
    }

    protected virtual void Idle()
    {
        throw new System.Exception("Calling Actor base method Idle");
    }

    protected virtual void WalkTo()
    {
        throw new System.Exception("Calling Actor base method WalkTo");
    }

    public enum ActionToTake
    {
        None,
        MeleeAttack,
        Idle,
        WalkTo
    }
}
