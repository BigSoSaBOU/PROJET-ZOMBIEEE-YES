using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{
    private NavMeshAgent _agent;
    private survivant _target = null;
    private float _updateDestinationCountdown = 0f;
    public float updateDesinationInterval = 0.5f;
    private Vector3 randomPosition;
    // Start is called before the first frame update
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (_target != null)
        {
            _updateDestinationCountdown = _updateDestinationCountdown - Time.deltaTime;

            if (_updateDestinationCountdown <= 0f)
            {
                _agent.destination = _target.transform.position;
                _updateDestinationCountdown = updateDesinationInterval;
            }
        }
        else
        {
            _updateDestinationCountdown = _updateDestinationCountdown - Time.deltaTime;
            if (_updateDestinationCountdown <= 0f)
            {
                randomPosition = new Vector3(Random.Range(-200, 201), 5, Random.Range(-200, 201));
                _agent.destination = randomPosition;
            }
           
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        survivant survivat = other.GetComponent<survivant>();
        if (survivat != null)
        {
            _target = survivat;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == _target)
        {
            _target = null;
        }

    }

}
