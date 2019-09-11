using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AIInputAction", menuName = "ScriptableObjects/Actions/AIInputAction")]
public class AIInputAction : ActionLogic
{
    public string VectorKeyName;

    public string TargetKeyName;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        Vector3 targetVec = blackboard.BlackboardData.At<Vector2>(TargetKeyName);

        blackboard.BlackboardData.Insert(VectorKeyName, new Vector2(targetVec.x, targetVec.y));
    }
}
