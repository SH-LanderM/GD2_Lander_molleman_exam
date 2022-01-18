using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRooms : MonoBehaviour
{
    [SerializeField]
    private GameObject Left;
    [SerializeField]
    private GameObject Right;
    [SerializeField]
    private GameObject WindowUI;

    public string CurrentRoom = "Window";
    private void Update()
    {
        if(CurrentRoom == "Window")
        {
            WindowUI.active = true;
            Left.active = true;
            Right.active = true;
        }
        if (CurrentRoom == "Crafting")
        {
            WindowUI.active = false;
            Left.active = false;
            Right.active = true;
        }
        if (CurrentRoom == "Private")
        {
            WindowUI.active = false;
            Left.active = true;
            Right.active = false;
        }
    }
}
