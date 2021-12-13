using UnityEngine;

public class DefaultProjectile : Projectile
{
    void Start()
    {   
        ProjectileRB.AddRelativeForce(Vector3.forward * FireForce, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<PlayerStats>().HP -= Damage; collision.gameObject.GetComponent<PlayerStats>().UpdateHealth();
        Destroy(gameObject);
    }
}
