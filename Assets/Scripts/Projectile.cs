using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public Rigidbody ProjectileRB;
    public float FireForce = 10;
    public int Damage;

    private void Awake()
    {
        ProjectileRB = GetComponent<Rigidbody>();
    }
}
