using System.Collections;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected float FireRate;
    protected bool CanShoot = true;
    protected Vector3 ProjectileSpawnOffset;

    public abstract void Shoot();

    protected IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(FireRate);
        CanShoot = true;
    }
}
