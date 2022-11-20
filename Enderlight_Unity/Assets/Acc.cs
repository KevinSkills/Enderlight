using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acc : MonoBehaviour
{


    public EventManager eventManager;


    private void Start()
    {
        eventManager.findEventWithName("MoveForward").AddListener(MoveForward);
    }
    public void MoveForward(GameEventInfo g)
    {
        int height = g.ints[0];
        print("Height: " + height);
        print(((GameObject)g.objects[0]).name);
    }

}
