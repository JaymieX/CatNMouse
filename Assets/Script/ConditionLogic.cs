using UnityEngine;

public abstract class ConditionLogic : ScriptableObject
{
    public StateNode TrueStateTransition;
    public StateNode FalseStateTransition;

    public abstract bool Execute(ref BlackboardComponent blackboard);
}
