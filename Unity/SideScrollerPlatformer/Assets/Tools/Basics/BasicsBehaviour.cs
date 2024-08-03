using System;
using UnityEngine;

public class BasicsBehaviour : MonoBehaviour
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
    
    public Colors colorChoice;

    public void UseColor()
    {
        switch (colorChoice)
        {
            case Colors.Red:
                //Lock the door
                LockDoor();
                break;
            case Colors.Green:
                //Open the Door
                break;
            case Colors.Blue:
                //Destroy the door
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        UseColor();
    }

    //Red Fuctionality
    public void LockDoor()
    {
        Debug.Log("Door Locked");
    }
}