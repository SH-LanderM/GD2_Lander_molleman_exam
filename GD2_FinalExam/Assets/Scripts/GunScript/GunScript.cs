using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunmoveforward : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    public void OrderinLayerUp()
    {
        renderer.sortingOrder = 11;
    }
}
