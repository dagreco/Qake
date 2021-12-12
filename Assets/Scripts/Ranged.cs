using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ranged : Weapon
{
    public int StartingAmmo;
    public int MagazineSize;
    [HideInInspector] public int AmmoInMagazine;
    [HideInInspector] public GameObject ProjectileSpawnpoint;
    public Vector3 PositionOffset;

    public abstract override void Shoot();
    public abstract override void Reload();

  

}
