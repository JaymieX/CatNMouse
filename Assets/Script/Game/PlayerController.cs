using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public string CollisionKey;
    public string DmgKey;
    public string HealthKey;

    public UIController UIControllerObject;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert("speed", Speed);
        GetComponent<BlackboardComponent>().BlackboardData.Insert(CollisionKey, false);

        GetComponent<BlackboardComponent>().BlackboardData.Insert(DmgKey, false);
        GetComponent<BlackboardComponent>().BlackboardData.Insert(HealthKey, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HP: " + GetComponent<BlackboardComponent>().BlackboardData.At<int>(HealthKey));

        if (GetComponent<BlackboardComponent>().BlackboardData.At<int>(HealthKey) == 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            GetComponent<BlackboardComponent>().BlackboardData.Insert(CollisionKey, true);
            GetComponent<BlackboardComponent>().BlackboardData.Insert(DmgKey, true);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert(CollisionKey, false);
    }
}
