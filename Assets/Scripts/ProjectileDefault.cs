using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDefault : MonoBehaviour
{
    private Rigidbody _projectileRB;
    public float FireForce = 10;
    // Start is called before the first frame update
    void Start()
    {
       _projectileRB = GetComponent<Rigidbody>();
        MoveProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveProjectile()
    {
        _projectileRB.AddRelativeForce(Vector3.forward*FireForce,ForceMode.VelocityChange);
    }    

    private void FixedUpdate()
    {
        
    }
}
