using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemonMove : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent is not attached!");
            enabled = false;
        }

        if (player == null)
        {
            Debug.LogError("Player transform is not assigned!");
            enabled = false;
        }
    }

    void Update()
    {
        if (player != null && agent != null)
        {
            agent.destination = player.position;
        }
    }
}
