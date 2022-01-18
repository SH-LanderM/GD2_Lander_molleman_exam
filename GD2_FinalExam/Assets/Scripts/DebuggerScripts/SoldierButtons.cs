using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoldierButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject _soldierPrefab;

    private GameObject _currentSoldier;
    


    public void SpawnSoldier()
    {
        if(_currentSoldier == null)
        {
            _currentSoldier = Instantiate(_soldierPrefab, new Vector3(5, 0, 0), Quaternion.identity);
            _currentSoldier.GetComponent<Animator>().Play("Soldier");
        }
    }
    public void RemoveSoldier()
    {
        _currentSoldier = GameObject.FindGameObjectWithTag("Soldier");
        if (_currentSoldier != null)
        {

            _currentSoldier.GetComponent<Animator>().Play("SoldierExit");
            
                Destroy(_currentSoldier);
       
        }
    }

}
