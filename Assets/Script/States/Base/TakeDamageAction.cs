using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TakeDamageAction", menuName = "ScriptableObjects/Actions/TakeDamageAction")]
public class TakeDamageAction : ActionLogic
{
    public string DmgKey;
    public string HealthKey;

    public override void Execute(ref BlackboardComponent blackboard)
    {
        if (blackboard.BlackboardData.At<bool>(DmgKey))
        {
            int hp = blackboard.BlackboardData.At<int>(HealthKey) - 1;
            if (hp < 0) hp = 0;

            blackboard.BlackboardData.Insert(HealthKey, hp);
            blackboard.BlackboardData.Insert(DmgKey, false);

            blackboard.gameObject.GetComponent<PlayerController>().UIControllerObject.ChangeHealth(hp);
        }
    }
}
