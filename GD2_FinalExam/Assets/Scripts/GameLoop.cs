using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour
{
    public int _numberSoldiers;
    public int _SoldierLeft;
    public bool NoMoreSoldiers;
    

    [SerializeField]
    private GameObject NextDay;

    [SerializeField]
    private Text NumberDaysText;
    public int NumberDays;

    [SerializeField]
    private Text SuccessfullrepairsText;
    public int Succesfullrepairs;
    [SerializeField]
    private Text FailedRepairsText;
    public int FailedRepairs;
    [SerializeField]
    private Text DuctapeUsedText;
    public int DuctapeUsed;

    // Start is called before the first frame update
    void Start()
    {
        NumberDays = 0;
        NextDay.SetActive(false);
        NoMoreSoldiers = false;
        _SoldierLeft = 0;

        Succesfullrepairs = 0;
        FailedRepairs = 0;
        DuctapeUsed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(NoMoreSoldiers)
        {
            NextDay.SetActive(true);
        }

        NumberDaysText.text = NumberDays.ToString();
        SuccessfullrepairsText.text = Succesfullrepairs.ToString();
        FailedRepairsText.text = FailedRepairs.ToString();
        DuctapeUsedText.text = DuctapeUsed.ToString();
    }

    

    
    
}
