using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    RigidBodyManager rigidBodyManager;
    [SerializeField] [Range(0,1000)] float speed = 10f;
    [SerializeField] GameObject target;

    bool isTransitioning = false;
    void Awake()
    {
        speed = 10 * speed;
        rigidBodyManager = GetComponent<RigidBodyManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidBodyManager.ForwardAlongZ(false, speed);
    }
}
