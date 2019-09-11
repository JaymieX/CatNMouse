using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public float Speed;

    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert("speed", Speed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = Target.transform.position;
        Vector3 thisPos = transform.position;
        Vector3 offset = targetPos - thisPos;
        offset.Normalize();

        GetComponent<BlackboardComponent>().BlackboardData.Insert("target", new Vector2(offset.x, offset.y));
    }
}
