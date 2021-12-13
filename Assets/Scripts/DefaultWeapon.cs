using UnityEngine;

public class DefaultWeapon : Ranged
{

    public override void Reload()
    {
        //TODO Implement reloading
    }

    private void LoadNextShot()
    {
        ReadyToShoot = true;
    }

    private void Awake()
    {
        ProjectileSpawnpoint = transform.GetChild(0).gameObject.transform;
    }

}
