using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TimerCondition", menuName = "ScriptableObjects/Conditions/TimerCondition")]
public class TimerCondition : ConditionLogic
{
    public override bool Execute(ref BlackboardComponent blackboard)
    {
        return blackboard.TimeSinceState >= 3f;
    }
}
