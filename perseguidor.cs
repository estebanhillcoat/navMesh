using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perseguir : MonoBehaviour
{
    
    public Transform objetivo;
    public NavMeshAgent perseguidor;

    void Update()
    {
        perseguidor.destination = objetivo.position;
    }
}
