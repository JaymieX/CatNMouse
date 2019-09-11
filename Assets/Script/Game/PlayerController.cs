using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BlackboardComponent>().BlackboardData.Insert("speed", Speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
