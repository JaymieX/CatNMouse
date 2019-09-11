using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveToAction", menuName = "ScriptableObjects/Actions/MoveToAction")]
public class MoveToAction : ActionLogic
{
    public string VectorKeyName;

    public string SpeedKeyName;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        Vector2 vec = blackboard.BlackboardData.At<Vector2>(VectorKeyName);
        float speed = blackboard.BlackboardData.At<float>(SpeedKeyName);

        blackboard.transform.Translate(vec * speed);
    }
}
