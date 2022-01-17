using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtons : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    public void Goleft()
    {
        _mainCamera.transform.position -= new Vector3(19,0,0);
    }
    public void GoRight()
    {
        _mainCamera.transform.position += new Vector3(19, 0, 0);
    }
}
