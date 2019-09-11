using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputController : InputController
{
    public KeyCode Up, Down, Left, Right;

    private void Start()
    {
        Blackboard.Insert<float>("X", 0);
        Blackboard.Insert<float>("Y", 0);
    }

    public override void Execute()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKeyDown(Up))
        {
            vel.y = 1;
        }

        if (Input.GetKeyDown(Down))
        {
            vel.y = -1;
        }

        if (Input.GetKeyDown(Left))
        {
            vel.x = -1;
        }

        if (Input.GetKeyDown(Right))
        {
            vel.x = 1;
        }

        vel.Normalize();

        Blackboard.Insert("X", vel.x);
        Blackboard.Insert("Y", vel.y);
    }
}
