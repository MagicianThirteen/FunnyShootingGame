using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent _findPathagent;
    void Start()
    {
        _findPathagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player=GameObject.FindGameObjectWithTag("Player");
        _findPathagent.SetDestination(player.transform.position);
    }
}
