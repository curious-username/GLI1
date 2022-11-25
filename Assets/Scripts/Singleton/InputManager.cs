using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Unable to find Input Manager!");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void Input()
    {

    }

}
