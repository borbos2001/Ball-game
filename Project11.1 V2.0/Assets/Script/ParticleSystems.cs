using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystems : MonoBehaviour
{
    [SerializeField] private Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.position;  
    }
}
