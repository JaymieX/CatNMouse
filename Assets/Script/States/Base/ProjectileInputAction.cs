using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileInputAction", menuName = "ScriptableObjects/Actions/ProjectileInputAction")]
public class ProjectileInputAction : ActionLogic
{
    public Vector2 Direction;

    public string VectorKeyName;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        blackboard.BlackboardData.Insert(VectorKeyName, Direction);
    }
}
