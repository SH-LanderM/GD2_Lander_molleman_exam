using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public SoldierSystem _soldierSystem;
    public bool _moveSoldier;
    public GameObject _soldier;
    [SerializeField]
    private float _speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(_moveSoldier)
        {
            float Step = _speed * Time.deltaTime;
            Vector3 TargetTransform = _soldier.transform.position - new Vector3(-5, 0, 0);
            _soldier.transform.position = Vector3.MoveTowards(_soldier.transform.position, TargetTransform, Step);

            if(_soldier.transform.position == TargetTransform)
            _moveSoldier = false;
        }
    }

    
    
}
