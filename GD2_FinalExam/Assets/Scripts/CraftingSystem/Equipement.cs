using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Equipement : MonoBehaviour , IDropHandler
{
    [SerializeField]
    private GameObject equipement;

    public bool Hasgun = false;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null && Hasgun)
        {
            Debug.Log("Drop");
            //Temporary until real images made 
            this.gameObject.GetComponent<Image>().color = Color.green;
        }
    }

    public void TakeGun()
    {
        equipement = GameObject.FindGameObjectWithTag("Gun");
        this.gameObject.GetComponent<Image>().sprite = equipement.GetComponent<SpriteRenderer>().sprite;

        //Temporary until real images made 
        this.gameObject.GetComponent<Image>().color = Color.red;

        equipement.SetActive(false);
        Hasgun = true;
        


    }
}
