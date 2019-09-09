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

    public Action currentAction;

    public GameObject Player { get => player; set => player = value; }
    public float AggroRange { get => aggroRange; }
    public float MeleeRange { get => meleeRange; }

    protected void Update()
    {
        if(think)
        {
            Action result = bunnyBrain.Think();

            if (result != Action.None)
            {
                currentAction = result;
            }

            switch (result)
            {
                case Action.MeleeAttack:
                    MeleeAttack();
                    break;

                case Action.Idle:
                    Idle();
                    break;

                case Action.WalkTo:
                    WalkTo();
                    break;
            }
           
            
        }

    }

    //Actions
    
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

    public enum Action
    {
        None,
        MeleeAttack,
        Idle,
        WalkTo
    }
}
