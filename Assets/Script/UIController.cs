using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject HP1, HP2, HP3;
    private int _health = 3;

    public void ChangeHealth(int newHP)
    {
        _health = newHP;

        switch(_health)
        {
            case 2:
                HP3.gameObject.SetActive(false);
                break;
            case 1:
                HP2.gameObject.SetActive(false);
                break;
            case 0:
                HP1.gameObject.SetActive(false);
                break;
        }
    }
}
