using UnityEngine;

public abstract class ActionLogic : ScriptableObject
{
    public abstract void Execute(ref BlackboardComponent blackboard);
}
