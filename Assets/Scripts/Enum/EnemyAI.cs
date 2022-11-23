using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    private void Start()
    {
        currentState = EnemyState.Patroling;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patroling:
                Debug.Log($"{EnemyState.Patroling}");
                break;
            case EnemyState.Attacking:
                Debug.Log($"{EnemyState.Attacking}");
                break;
            case EnemyState.Chasing:
                Debug.Log($"{EnemyState.Chasing}");
                break;
            case EnemyState.Death:
                Debug.Log($"{EnemyState.Death}");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
        }
    }
}
