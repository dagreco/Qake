using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour
{
    public GameObject Projectile;
    public float FireRate = 0.4f;
    public GameObject Spawnpoint;
    private bool _weaponReady = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    public void FireWeapon()        
    {
        if (_weaponReady)
        {
            Instantiate(Projectile,Spawnpoint.transform.position, transform.rotation);
            _weaponReady = false;
            StartCoroutine("shotCooldown");
        }

    }
    IEnumerator shotCooldown()
    {
        yield return new WaitForSeconds(FireRate);
        _weaponReady = true;
    }
    

}
