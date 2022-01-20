using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoldierButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject _soldierPrefab;
    [SerializeField]
    private GameObject _gunPrefab;
    [SerializeField]
    private GameLoop _gameLoop;
    [SerializeField]
    private GameObject _text;

    private GameObject _currentSoldier;
    private GameObject _currentGun;
    private bool HasGun;
    public bool Gunrepaired;

    private void Awake()
    {
        _text.SetActive(false);
    }

    public void SpawnSoldier()
    {
        if(_currentSoldier == null)
        {
            if (_gameLoop._numberSoldiersLeft > 0)
            {
                _currentSoldier = Instantiate(_soldierPrefab, new Vector3(5, 0, 0), Quaternion.identity);
                Gunrepaired = false;
                _currentSoldier.GetComponent<Animator>().Play("Soldier");
                _gameLoop._numberSoldiersLeft -= 1;
            }
            else if (_gameLoop._numberSoldiersLeft <= 0)
            {
                _text.SetActive(true);
            }
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
