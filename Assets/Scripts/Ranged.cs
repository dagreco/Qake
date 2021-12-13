using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ranged : Weapon
{
    public int StartingAmmo;
    public int MagazineSize;
    [HideInInspector] public int AmmoInMagazine;
    [HideInInspector] public Transform ProjectileSpawnpoint;
    public Vector3 PositionOffset;
    public GameObject Projectile;

    public override void Shoot()
    {
        if (ReadyToShoot)
        {
            Instantiate(Projectile, ProjectileSpawnpoint.position, ProjectileSpawnpoint.rotation).GetComponent<Projectile>().Damage = Damage;
            Invoke("LoadNextShot", FireRate);
            ReadyToShoot = false;
            Debug.Log("Shot");
        }
    }
    public abstract override void Reload();

}
