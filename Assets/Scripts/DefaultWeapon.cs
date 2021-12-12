using UnityEngine;

public class DefaultWeapon : Ranged
{
    public GameObject Projectile;
    public override void Shoot()
    {
        if (ReadyToShoot)
        {
            Instantiate(Projectile, ProjectileSpawnpoint.transform.position, ProjectileSpawnpoint.transform.rotation);
            Invoke("LoadNextShot", FireRate);
            ReadyToShoot = false;
            Debug.Log("Shot");
        }
    }

    public override void Reload()
    {
        throw new System.NotImplementedException();
    }

    private void LoadNextShot()
    {
        ReadyToShoot = true;
    }

    private void Awake()
    {
        ProjectileSpawnpoint = transform.GetChild(0).gameObject;
        GetComponentInParent<Inventory>().SetActiveWeapon(gameObject);
    }

}
