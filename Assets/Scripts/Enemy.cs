using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : LivingEntity
{
    // Start is called before the first frame update
    private NavMeshAgent _findPathagent;
    private Transform target;
    protected override void Start()
    {
        base.Start();
        _findPathagent = GetComponent<NavMeshAgent>();
        target=GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(UpdatePathFind());
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator UpdatePathFind()
    {
        float freshRare = .25f;
        while (target!=null&&!isDead)
        {
            Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.y);
            _findPathagent.SetDestination(targetPosition);
            yield return new WaitForSeconds(freshRare);
        }
    }
    
    
}
