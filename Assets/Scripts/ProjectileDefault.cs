using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDefault : MonoBehaviour
{
    private Rigidbody projectileRB;
    public float fireForce = 10;
    // Start is called before the first frame update
    void Start()
    {
        projectileRB = GetComponent<Rigidbody>();
        MoveProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveProjectile()
    {
        projectileRB.AddForce(Vector3.forward*fireForce,ForceMode.VelocityChange);
    }    

    private void FixedUpdate()
    {
        
    }
}
