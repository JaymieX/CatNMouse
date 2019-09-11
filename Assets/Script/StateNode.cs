using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StateNode", menuName = "ScriptableObjects/StateNodes/StateNode")]
public class StateNode : ScriptableObject
{
    public List<ConditionLogic> Conditions;
    public List<ActionLogic> Actions;

    public StateNode()
    {
        Conditions = new List<ConditionLogic>();
        Actions = new List<ActionLogic>();
    }

    public void TestConditions(BlackboardComponent blackboard)
    {
        foreach (ConditionLogic c in Conditions)
        {
            bool res = c.Execute(ref blackboard);

            if (res && c.TrueStateTransition != null)
            {
                blackboard.Transition(c.TrueStateTransition);
            }
            else if (!res && c.FalseStateTransition != null)
            {
                blackboard.Transition(c.FalseStateTransition);
            }
        }
    }

    public void ExecuteActions(BlackboardComponent blackboard)
    {
        foreach (ActionLogic a in Actions)
        {
            a.Execute(ref blackboard);
        }
    }
}
