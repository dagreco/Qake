using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 0.4f;
    public GameObject spawnpoint;
    private bool weaponReady = true;
    private bool oSkourisVromaei = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update4()
    {
       
    }

    private void Skouris()
    {
        Debug.Log("i mana tou skouri");
    }

    // Update is called once per frame
    public void FireWeapon()        
    {
        if (weaponReady)
        {
            Instantiate(projectile,spawnpoint.transform.position, transform.rotation);
            weaponReady = false;
            StartCoroutine("shotCdown");
        }

    }
    
    

}
