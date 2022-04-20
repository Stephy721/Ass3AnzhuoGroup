using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ememy02 : MonoBehaviour
{

    private NavMeshAgent ag;
 
    private GameObject target; 

    void Start()
    {

        ag = transform.GetComponent<NavMeshAgent>();

        target = GameObject.Find("Player");

    }

    private void Update()
    {
        if (Game02Controller.Instance.IsRun == true)
        {
            ag.SetDestination(target.transform.position);

        }
    }


}
