using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public EventManager eventManager;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEventInfo g = new GameEventInfo();
            print(g);
            g.ints.Add(1);
            g.objects.Add(this.gameObject);
            eventManager.findEventWithName("MoveForward").Invoke(g);
        }


        


    }


}
