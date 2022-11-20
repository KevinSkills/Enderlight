using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameEvent : MonoBehaviour
{
    private Action<GameEventInfo> theEvent;

    public void AddListener(Action<GameEventInfo> a)
    {
        theEvent += a;
    }

    
    
    public void Invoke(GameEventInfo gei)
    {
        theEvent(gei);
    }
}
