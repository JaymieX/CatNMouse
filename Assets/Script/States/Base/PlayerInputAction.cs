using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInputAction", menuName = "ScriptableObjects/Actions/PlayerInputAction")]
public class PlayerInputAction : ActionLogic
{
    public string VectorKeyName;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        Vector3 cursorPos = Input.mousePosition;
        Vector3 movePos = Camera.main.ScreenToWorldPoint(cursorPos) - blackboard.transform.position;
        movePos.z = 0;
        movePos.Normalize();

        blackboard.BlackboardData.Insert(VectorKeyName, new Vector2(movePos.x, movePos.y));
    }
}
