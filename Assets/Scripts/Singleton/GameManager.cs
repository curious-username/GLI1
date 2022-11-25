using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance 
    {

        get
        {
            if(_instance == null)
            {
                Debug.LogError("Unable to find gamemanager");
            }
            return _instance;
        }
    

    }
    

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayMessage()
    {
        Debug.Log("I am from the game manager");
    }




}
