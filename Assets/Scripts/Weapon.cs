using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected float FireRate;
    protected bool WeaponReady;
    public Vector3 SpawnOffset;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }


    public abstract void FireWeapon();


}
