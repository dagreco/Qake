using UnityEngine;

public class WeaponDefault : Weapon
{
    [SerializeField] private GameObject Projectile;
    private GameObject Spawnpoint;

    void Awake()
    {
        FireRate = 0.4f;
        Spawnpoint = transform.GetChild(0).gameObject;
    }
  
    // Update is called once per frame
    public override void Shoot()
    {
        if (CanShoot)
        {
            Instantiate(Projectile, Spawnpoint.transform.position, transform.rotation);
            CanShoot = false;
            StartCoroutine("ShotCooldown");
        }
    }
}