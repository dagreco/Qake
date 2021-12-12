using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Expandable Dictionary containing all the Weapons and coresponding values
    private Dictionary<string, GameObject> _weaponList;

    // Weapon the player is currently holding (E.g DefaultWeapon = 1)
    public GameObject WeaponAtHand;
    private string _collisionWeaponTag;

    [SerializeField] private GameObject _defaultWeapon;
    [SerializeField] private GameObject _weaponGrenade;


    void Start()
    {

     

    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
         _collisionWeaponTag = other.transform.tag;
         Destroy(other.gameObject);
         SpawnWeaponPickup(_collisionWeaponTag);
    }

    void SpawnWeaponPickup(string tag)
    {

        switch (tag)
        {
            case "DefaultWeapon":

                Object.Destroy(WeaponAtHand);
                //Destroy(transform.GetChild(0).gameObject);
                var obj = Instantiate(_defaultWeapon);
                obj.transform.position = transform.position + new Vector3(0, 0, 0.3f); 
                obj.transform.parent = gameObject.transform;
                WeaponAtHand = transform.GetChild(1).gameObject;

                break;

            case "Grenade":

                Object.Destroy(WeaponAtHand);
                //Destroy(transform.GetChild(0).gameObject);
                var obj2 = Instantiate(_weaponGrenade);
                obj2.transform.position = transform.position + new Vector3(1, 0, 0);
                obj2.transform.parent = gameObject.transform;
                WeaponAtHand = transform.GetChild(1).gameObject;

                break;

            default:

                break;
        }

    }


}
