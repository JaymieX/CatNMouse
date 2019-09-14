using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollisionConditionObject", menuName = "ScriptableObjects/Conditions/CollisionConditionObject")]
public class CollisionConditionObject : ConditionLogic
{
    public string CollisionKey;

    public override bool Execute(ref BlackboardComponent blackboard)
    {
        return blackboard.BlackboardData.At<bool>(CollisionKey);
    }
}
