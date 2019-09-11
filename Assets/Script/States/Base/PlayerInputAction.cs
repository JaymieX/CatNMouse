using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInputAction", menuName = "ScriptableObjects/Actions/PlayerInputAction")]
public class PlayerInputAction : ActionLogic
{
    public KeyCode Up, Down, Left, Right;

    public string VectorKeyName;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        Vector2 vec = new Vector2(0,0);
        if (Input.GetKey(Up))
        {
            vec.y = 1;
        }
        if (Input.GetKey(Down))
        {
            vec.y = -1;
        }
        if (Input.GetKey(Left))
        {
            vec.x = -1;
        }
        if (Input.GetKey(Right))
        {
            vec.x = 1;
        }

        vec.Normalize();
        blackboard.BlackboardData.Insert(VectorKeyName, vec);
    }
}
