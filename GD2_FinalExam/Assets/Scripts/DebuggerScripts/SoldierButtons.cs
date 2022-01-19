using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoldierButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject _soldierPrefab;
    [SerializeField]
    private GameObject _gunPrefab;

    private GameObject _currentSoldier;
    private GameObject _currentGun;
    private bool HasGun;
    public bool Gunrepaired;



    public void SpawnSoldier()
    {
        if(_currentSoldier == null)
        {
            _currentSoldier = Instantiate(_soldierPrefab, new Vector3(5, 0, 0), Quaternion.identity);
            Gunrepaired = false;
            _currentSoldier.GetComponent<Animator>().Play("Soldier");
        }
    }
    public void RemoveSoldier()
    {
        if(Gunrepaired == true &&_currentGun !=null)
        
        
        if (_currentSoldier != null)
        {

            _currentSoldier.GetComponent<Animator>().Play("SoldierExit");
            if (_currentGun != null)
            {
                Destroy(_currentGun);
            }
                Invoke("DestroySoldier", 1f);
            
       
        }
    }

    public void GetGun()
    {
        if (_currentSoldier != null && HasGun == false)
        {
            _currentGun = Instantiate(_gunPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            _currentSoldier.GetComponent<Animator>().Play("PullOutWeapon");
            HasGun = true;

        }
    }

    private void DestroySoldier()
    {
        Destroy(_currentSoldier);
        HasGun = false;
        if(_currentGun != null)
        {
            Destroy(_currentGun);
        }
    }
        



}
