using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardComponent : MonoBehaviour
{
    public Blackboard BlackboardData;

    [SerializeField]
    private StateNode _currentNode;

    public BlackboardComponent()
    {
        BlackboardData = new Blackboard();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _currentNode.TestConditions(this);
        _currentNode.ExecuteActions(this);
    }

    public void Transition(StateNode node)
    {
        _currentNode = node;
    }
}
