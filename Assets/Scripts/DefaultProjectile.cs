using UnityEngine;

public class DefaultProjectile : Projectile
{
    void Start()
    {   
        ProjectileRB.AddRelativeForce(Vector3.forward * FireForce, ForceMode.VelocityChange);
    }

    
}
