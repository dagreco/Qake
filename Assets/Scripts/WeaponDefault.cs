using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 0.4f;
    public GameObject spawnpoint;
    private bool weaponReady = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    void FireWeapon()        
    {
        if (weaponReady)
        {
            Instantiate(projectile,spawnpoint.transform.position, transform.rotation);
            weaponReady = false;
            StartCoroutine("shotCooldown");
        }

    }
    IEnumerator shotCooldown()
    {
        yield return new WaitForSeconds(fireRate);
        weaponReady = true;
    }
    

}
