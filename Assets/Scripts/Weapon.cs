using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] public int Damage;
    [SerializeField] protected bool ReadyToShoot = true;
    [SerializeField] protected float FireRate;

    public abstract void Shoot();
    public abstract void Reload();

    
}

