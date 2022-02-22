using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour
{
    public Vector3 startposition;
    [SerializeField]
    private Vector3 homeposition;
    private Vector3 distance;


    void Start()
    {
        print(" My start position is " + startposition);
        print(" My home posistion is " + homeposition);
        distance = homeposition - startposition;
        print(" the distance to cover is " + distance.magnitude);

        float finaldistance = distance.magnitude;
        if (finaldistance > 0)
            print("to move forward");
        else if (finaldistance < 0)
            print("to move backward");
        else if (finaldistance == 0)
            print(" you have reached ");
    }   

    void Update()
    {
        CheckPlayerMovement(KeyCode.UpArrow,new Vector3(0,0,1));
        CheckPlayerMovement(KeyCode.DownArrow, new Vector3(0, 0, -1));
        CheckPlayerMovement(KeyCode.LeftArrow, new Vector3(-1, 0, 0));
        CheckPlayerMovement(KeyCode.RightArrow, new Vector3(1, 0, 0));
        CheckPlayerMovement(KeyCode.M, new Vector3(0, 1, 0));
        CheckPlayerMovement(KeyCode.N, new Vector3(0, -1, 0));
    }
 

    private void CheckPlayerMovement(KeyCode arrow, Vector3 value)
    {
        if (Input.GetKeyDown(arrow))
        {
            startposition = startposition + new Vector3(0, 0, 1);
            distance = homeposition - startposition;
            print("distance to home is " + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("press uparrow to move forward");
            else if (finaldistance < 0)
                print("press down arrow to backward");
            else if (finaldistance == 0)
                print("You have reached");
        }
    }
}
