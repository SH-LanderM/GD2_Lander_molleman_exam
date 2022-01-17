using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtons : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;
    [SerializeField]
    private SwitchRooms _roomName;


    public void Goleft()
    {
        if(_roomName.CurrentRoom == "Window")
        {
            _mainCamera.transform.position -= new Vector3(19, 0, 0);
            _roomName.CurrentRoom = "Crafting";
        }
        else if(_roomName.CurrentRoom == "Private")
        {
            _mainCamera.transform.position -= new Vector3(19, 0, 0);
            _roomName.CurrentRoom = "Window";
        }
        
    }
    public void GoRight()
    {
        if (_roomName.CurrentRoom == "Window")
        {
            _mainCamera.transform.position += new Vector3(19, 0, 0);
            _roomName.CurrentRoom = "Private";
        }
        else if (_roomName.CurrentRoom == "Crafting")
        {
            _mainCamera.transform.position += new Vector3(19, 0, 0);
            _roomName.CurrentRoom = "Window";
        }
    }
}
