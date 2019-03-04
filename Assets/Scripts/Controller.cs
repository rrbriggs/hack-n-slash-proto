using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int Index { get; private set; }
    public bool IsAssigned { get; set; }

    private string attackButton;

    public bool attack;

    private void Update()
    {
        if (!string.IsNullOrEmpty(attackButton))
        {
            attack = Input.GetButton(attackButton);
        }
    }

    internal void SetIndex(int index)
    {
        Index = index;
        attackButton = "Attack" + Index;
        gameObject.name = "Controller " + Index;

    }

    internal bool AnyButtonDown()
    {
        return attack;
    }
}
