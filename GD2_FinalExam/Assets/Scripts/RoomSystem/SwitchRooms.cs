using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRooms : MonoBehaviour
{
    [SerializeField]
    private GameObject Left;
    [SerializeField]
    private GameObject Right;

    public string CurrentRoom = "Window";
    private void Update()
    {
        if(CurrentRoom == "Window")
        {
            Left.active = true;
            Right.active = true;
        }
        if (CurrentRoom == "Crafting")
        {
            Left.active = false;
            Right.active = true;
        }
        if (CurrentRoom == "Private")
        {
            Left.active = true;
            Right.active = false;
        }
    }
}
