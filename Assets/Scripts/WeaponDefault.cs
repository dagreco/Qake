using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 0.4f;
	public double healthPoints;
    public GameObject spawnpoint;
    private bool weaponReady = true;
    
    // Start is called before the first frame update
    void Start()
    {
        var x = "abc";
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    public void FireWeapon()        
    {
        if (weaponReady)
        {
            Instantiate(projectile,spawnpoint.transform.position, transform.rotation);
            weaponReady = false;
            StartCoroutine("shotSkouris");
			
        }

    }
    IEnumerator shotSkouris()
    {
        yield return new WaitForSeconds(fireRate);
        weaponReady = true;
    }
    

}
