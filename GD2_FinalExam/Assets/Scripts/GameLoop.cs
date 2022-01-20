using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public int _numberSoldiers;
    public int _SoldierLeft;
    public bool NoMoreSoldiers;

    [SerializeField]
    private GameObject NextDay;
    
    // Start is called before the first frame update
    void Start()
    {
        NextDay.SetActive(false);
        NoMoreSoldiers = false;
        _SoldierLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(NoMoreSoldiers)
        {
            NextDay.SetActive(true);
        }
    }

    

    
    
}
