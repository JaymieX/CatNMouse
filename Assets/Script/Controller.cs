using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    public Blackboard Blackboard { get; protected set; }

    public Controller()
    {
        Blackboard = new Blackboard();
    }

    public abstract void Execute();
}

public abstract class BehaviourController : Controller
{
    protected List<InputController> _inputControllers;

    public void AddInputController(ref InputController inputController)
    {
        _inputControllers.Add(inputController);
    }
}

public abstract class InputController : Controller
{
}