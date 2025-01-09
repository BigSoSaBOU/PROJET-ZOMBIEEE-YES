
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class survivant : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Plante _target = null;
    public zombie _zombie = null;
    private float _updateDestinationCountdown = 0f;
    public float updateDestinationInterval = 0.5f;
    private Vector3 randomPosition;
    //bool _hasTarget = false;


    // Start is called before the first frame update
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (_zombie != null)
        {
            _updateDestinationCountdown = _updateDestinationCountdown - Time.deltaTime;
            if (_updateDestinationCountdown <= 0f)
            {
                Vector3 destinationFuite = transform.position + (transform.position - _zombie.transform.position);
                _agent.destination = destinationFuite;
                //_hasTarget = true;
                float distanceSecurité = Vector3.Distance(transform.position, _zombie.transform.position);
                if (distanceSecurité > 15)                                                                                         //cassé 
                {
                    
                    randomPosition = new Vector3(Random.Range(-200, 201), transform.position.y, Random.Range(-200, 201));
                    _agent.destination = randomPosition;
                    _updateDestinationCountdown = updateDestinationInterval;
                   // _hasTarget = false;
                    //Debug.Log("zombie");

                }
                

            }
            

        }
        if (_target != null)
        {
            //if (_hasTarget == true)
                //return;
            _updateDestinationCountdown = _updateDestinationCountdown - Time.deltaTime;

            if (_updateDestinationCountdown <= 0f)
            {
                _agent.destination = _target.transform.position;
                _updateDestinationCountdown = updateDestinationInterval;
                //_hasTarget = true;

            }
            


        }
        
        else //ou : if (_target = null)
        {
           //if (_hasTarget == true)
               // return;
            _updateDestinationCountdown = _updateDestinationCountdown - Time.deltaTime;
            if (_updateDestinationCountdown <= 0f)
            {
                randomPosition = new Vector3(Random.Range(-50, 51), transform.position.y, Random.Range(-50, 51));
                _agent.destination = randomPosition;
                _updateDestinationCountdown = updateDestinationInterval;
                //_hasTarget = true;
            }
            return;

        }



    }
    private void OnTriggerEnter(Collider other)
    {
        Plante plante = other.GetComponent<Plante>();
        if (plante != null)
        {
            _target = plante;
        }
        zombie zombie = other.GetComponent<zombie>(); 
        if (zombie != null)
        {
            _zombie = zombie;
        }

        

    }

    private void OnTriggerExit(Collider other) //sisi
    {
        if (other == _target)
        {
            _target = null;
            
        }
        if (other == _zombie) 
        {
            _zombie = null;
        }
    }
    
    



}
