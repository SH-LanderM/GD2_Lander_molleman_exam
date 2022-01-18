using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ResourcesScript : MonoBehaviour , IDragHandler , IBeginDragHandler, IEndDragHandler
{
    
    private Vector2 StartingTransform;
    private RectTransform rectTransform;

    private CanvasGroup canvasGroup;

    

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private RectTransform UI;
    private void Awake()
    {
        StartingTransform = this.GetComponent<RectTransform>().anchoredPosition;
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        rectTransform.anchoredPosition += eventData.delta/UI.localScale / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        rectTransform.anchoredPosition = StartingTransform;
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
