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

    [Header("Buttons")]
    [SerializeField]
    private GameObject Call;
    [SerializeField]
    private GameObject Dismiss;
    [SerializeField]
    private GameObject Gun;
    [SerializeField]
    private GameObject NextDay;


    private TextBoxManager TextBoxManager;

    private GameObject _currentSoldier;
    private GameObject _currentGun;
    private bool HasGun;
    public bool Gunrepaired;

    private void Awake()
    {
        _text.SetActive(false);
        TextBoxManager = GameObject.FindGameObjectWithTag("TextBox").GetComponent<TextBoxManager>();
        TextBoxManager.gameObject.SetActive(false);

        Dismiss.SetActive(false);
        Gun.SetActive(false);
    }

    public void SpawnSoldier()
    {
        if(_currentSoldier == null)
        {
            if (_gameLoop._numberSoldiers > 0)
            {
                _currentSoldier = Instantiate(_soldierPrefab, new Vector3(5, 0, 0), Quaternion.identity);
                Gunrepaired = false;
                _currentSoldier.GetComponent<Animator>().Play("Soldier");

                _gameLoop._numberSoldiers -= 1;

                TextBoxManager.gameObject.SetActive(true);
                TextBoxManager.Talker.text = "Soldier :";
                TextBoxManager.Text.text = "Recruit at your service";

                Call.SetActive(false);
                Dismiss.SetActive(true);
                Gun.SetActive(true);
            }
            else if (_gameLoop._numberSoldiers <= 0)
            {
                _gameLoop.NoMoreSoldiers = true;
                _text.SetActive(true);
                Call.SetActive(false);
            }
        }
    }
    public void RemoveSoldier()
    {
        if (_currentGun != null)
        {

            if (_currentSoldier != null )
            {

                _currentSoldier.GetComponent<Animator>().Play("SoldierExit");

                Dismiss.SetActive(false);
                Gun.SetActive(false);
                Call.SetActive(true);
                if (Gunrepaired == true)
                {
                    TextBoxManager.Text.text = "Thank you sir";
                    _gameLoop._SoldierLeft++;
                }
                else if (Gunrepaired == false)
                {
                    TextBoxManager.Text.text = "I'll never make it with this";
                }
                
                if (_currentGun != null)
                {
                    Destroy(_currentGun);
                }
                Invoke("DestroySoldier", 1f);


            }
        }
    }

    public void GetGun()
    {
        if (_currentSoldier != null && HasGun == false)
        {
            _currentGun = Instantiate(_gunPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            _currentSoldier.GetComponent<Animator>().Play("PullOutWeapon");
            TextBoxManager.Text.text = "Here you go sir";
            HasGun = true;
            Gun.SetActive(false);
        }
    }

    public void NewDay()
    {
        _gameLoop._numberSoldiers = _gameLoop._SoldierLeft;
        _gameLoop._SoldierLeft = 0;
        _gameLoop.NoMoreSoldiers = false;
        _text.SetActive(false);
        NextDay.SetActive(false);
        Call.SetActive(true);

    }

    private void DestroySoldier()
    {
        Destroy(_currentSoldier);
        TextBoxManager.gameObject.SetActive(false);
        HasGun = false;
        if(_currentGun != null)
        {
            Destroy(_currentGun);
        }
    }
        



}
