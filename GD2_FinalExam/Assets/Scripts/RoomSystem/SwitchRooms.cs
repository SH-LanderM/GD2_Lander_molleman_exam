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
    [SerializeField]
    private GameObject CraftingUi;


    public string CurrentRoom = "Window";


    private void Awake()
    {
        CraftingUi.SetActive(false);

    }
    private void Update()
    {
        if(CurrentRoom == "Window")
        {
            CraftingUi.SetActive(false);
            WindowUI.SetActive(true);
            Left.SetActive(true);
            Right.SetActive(true);
        }
        if (CurrentRoom == "Crafting")
        {
            CraftingUi.SetActive(true);
            WindowUI.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(true);
            
        }
        if (CurrentRoom == "Private")
        {
            CraftingUi.SetActive(false);
            WindowUI.SetActive(false);
            Left.SetActive(true);
            Right.SetActive(false);
        }
    }
}
