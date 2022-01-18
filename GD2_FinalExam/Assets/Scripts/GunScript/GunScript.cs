using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunScript : MonoBehaviour 
{
    [SerializeField]
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    public void OrderinLayerUp()
    {
        renderer.sortingOrder = 11;
    }
    
    
}
