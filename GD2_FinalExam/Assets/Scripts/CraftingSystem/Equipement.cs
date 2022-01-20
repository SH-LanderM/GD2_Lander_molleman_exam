using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Equipement : MonoBehaviour , IDropHandler
{
    
    private GameObject equipement;

    [SerializeField]
    private Sprite Gunrepaired;

    [SerializeField]
    private GameLoop _gameloop;

    [SerializeField]
    private Sprite Empty;
    [SerializeField]
    private SoldierButtons soldierButtons;

    public bool Hasgun = false;

    
    private ResourcesScript Resource;
    


    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null && Hasgun)
        {
            Resource = eventData.pointerDrag.GetComponent<ResourcesScript>();
            Debug.Log("Drop");
            if (Resource.TypeOfResource == ResourcesScript.resourceType.Ductape)
            {
                this.gameObject.GetComponent<Image>().sprite = Gunrepaired;
                soldierButtons.Gunrepaired = true;
                _gameloop.DuctapeUsed++;
            }
        }
    }

    public void TakeGun()
    {
        equipement = GameObject.FindGameObjectWithTag("Gun");
        if (equipement != null && !soldierButtons.Gunrepaired)
        {
            this.gameObject.GetComponent<Image>().sprite = equipement.GetComponent<SpriteRenderer>().sprite;
            equipement.GetComponent<Animator>().enabled = false;

            

            equipement.SetActive(false); 
            Hasgun = true;
        }

    }

    public void GunRepaired()
    {
        if(equipement != null )
        {
            equipement.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<Image>().sprite;
            this.gameObject.GetComponent<Image>().sprite = Empty;
            
            equipement.SetActive(true);
            Hasgun = false;
            
        }
    }
}
