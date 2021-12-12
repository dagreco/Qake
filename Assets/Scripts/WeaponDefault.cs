using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : Weapon
{
    public GameObject Projectile;
    public float FireRate = 0.4f;
    public GameObject Spawnpoint;
    private bool _weaponReady = true;
    
    public GameObject Spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        FireRate = 0.4f;
        WeaponReady = true;
        SpawnOffset = new Vector3(0, 0, 0.4f);
    }
    private void Update()
    {
       // FireWeapon();
    }

    // Update is called once per frame
    public override void FireWeapon()
    {
        if (_weaponReady)
        {
            Instantiate(Projectile,Spawnpoint.transform.position, transform.rotation);
            _weaponReady = false;
        if (WeaponReady)
        {
            Instantiate(Projectile,Spawnpoint.transform.position, transform.rotation);
            WeaponReady = false;
            StartCoroutine("shotCooldown");
        }

    }
    IEnumerator shotCooldown()
    {
        yield return new WaitForSeconds(FireRate);
        _weaponReady = true;
        WeaponReady = true;
    }
     

}
