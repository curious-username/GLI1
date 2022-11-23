using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AI : MonoBehaviour
{
    private enum AIState
    {
        Walking,
        Jumping,
        Attack,
        Death
    }


    [SerializeField]
    Transform[] _waypoint;
    NavMeshAgent agent;
    private int _currentPoint = 0;
    bool _lastPoint;
    [SerializeField]
    private AIState _currentState;
    [SerializeField]
    private GameObject _attackParticleEffect;
    bool _isAttacking = true;
    bool _isLastPoint, _isTargetDead = false;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            _currentState = AIState.Jumping;
            agent.isStopped = true;
            
        }
        
        switch (_currentState)
        {
            case AIState.Walking:
                CalculateAIMovement();
                break;
            case AIState.Jumping:
                Debug.Log("Jumping");
                break;
            case AIState.Attack:
                if (_isAttacking == true)
                {
                    StartCoroutine(Attack());
                    _isAttacking = false;
                }
                break;
            case AIState.Death:
                Debug.Log("Target is dead");
                Death();
                break;
        }

    }

    void CalculateAIMovement()
    {
        
        agent.destination = _waypoint[_currentPoint].position;


        if(Vector3.Distance(gameObject.transform.position, _waypoint[_currentPoint].position) < 1f)
        {
            if(_isTargetDead == false)
            {
                _isAttacking = true;
                _currentState = AIState.Attack;
            }
            else
            {
                if (_isLastPoint == false)
                {
                    Forward();
                }
                else
                {
                    Backward();
                }
                _isTargetDead = false;
            }
            



        }
        //else if (Vector3.Distance(gameObject.transform.position, _waypoint[_currentPoint].position) < 1f)
        //    _currentState = AIState.Attack;


    }

    IEnumerator Attack()
    {
        agent.isStopped = true;
        _attackParticleEffect.transform.position = _waypoint[_currentPoint].position;
        _attackParticleEffect.SetActive(true);
        Debug.Log($"Attacking Point {_currentPoint}");
        yield return new WaitForSeconds(3.0f);
        _attackParticleEffect.SetActive(false);
        _currentState = AIState.Death;
        
    }

    void Death()
    {
        agent.isStopped = false;
        _isTargetDead = true;
        _currentState = AIState.Walking;
    }



    void Forward()
    {
        if(_currentPoint < _waypoint.Length - 1)
        {
            _currentPoint++;
            
        }
        else
        {
            _isLastPoint = true;
            _currentPoint--;
        }

    }

    void Backward()
    {
        if(_currentPoint != 0)
        {
            
            _currentPoint--;
        }
        else
        {
            _isLastPoint = false;
            _currentPoint++;
        }
        
    }

    


        

}
