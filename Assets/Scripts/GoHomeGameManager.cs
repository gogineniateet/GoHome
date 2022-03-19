using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeGameManager : MonoBehaviour
{
    public Vector2 startPosition;
    [SerializeField]
    private Vector2 homePosition;
    private Vector2 distance;
    
    void Start()
    {
        print("Hello Welcome to my game Go Home");
        print("Instructions how to play the game");
        print("Press up-arrow to move to forward \n Press down-arrow to move backward");
        print("My start position is " + startPosition);
        print("My home position is  " + homePosition);
        distance = homePosition - startPosition;
        print("The distance to cover is " + distance.magnitude);
        float finalDistance = distance.magnitude;
        if (finalDistance > 0 )
            print("To move forward");
        else if (finalDistance < 0)
            print("To move backward");
        else if (finalDistance == 0)
            print("You reached home");

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPosition = startPosition + new Vector2(0,1) ;
            distance  = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
            {
                print("Please press downarrow to move backward");
            }
            else if (finalDistance < 0)
                print("please press uparrow to forward");

            else if (finalDistance == 0)
                print("You reached home");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector2(0,-1);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
            {
                print("Please press downarrow to move backward");
            }
            else if (finalDistance < 0)
                print("please press uparrow to forward");
            else if (finalDistance == 0)
                print("You reached home");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPosition = startPosition + new Vector2(-1, 0);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
            {
                print("Please press downarrow to move backward");
            }
            else if (finalDistance < 0)
                print("please press uparrow to forward");
            else if (finalDistance == 0)
                print("You reached home");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startPosition = startPosition + new Vector2(1, 0);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance > 0)
            {
                print("Please press downarrow to move backward");
            }
            else if (finalDistance < 0)
                print("please press uparrow to forward");
            else if (finalDistance == 0)
                print("You reached home");
        }

    }
}
