using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<UIManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UpdateScore(int score)
    {
        Debug.Log($"{score}");
        Debug.Log("Notifying game manager");
        GameManager.Instance.DisplayMessage();
    }
}
