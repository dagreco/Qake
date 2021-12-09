using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDefault : MonoBehaviour
{
    public GameObject Projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FireWeapon()
    {
        Instantiate(Projectile);
    }
}
