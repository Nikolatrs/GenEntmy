using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float _spid = 0.3f;

    void Start()
    {
        
    }

    void Update()
    {
        
        var nextPosition = transform.forward *_spid;
        transform.position = nextPosition;

    }
}
