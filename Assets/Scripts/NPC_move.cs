using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_move : MonoBehaviour
{
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("nav er ik på " + gameObject.name);
        }
        /*else
        {
            SetDestination();
        }*/
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targeVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targeVector);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetDestination();
    }
}
