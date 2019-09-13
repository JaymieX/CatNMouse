using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert("speed", Speed);
    }

    void Update()
    {
        if (transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }
    }
}
