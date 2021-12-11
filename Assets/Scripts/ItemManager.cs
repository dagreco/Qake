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
    [SerializeField] private GameObject _player;


    void Start()
    {
        WeaponAtHand = transform.GetChild(0).gameObject;
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collision");
        
        _collisionWeaponTag = other.collider.tag;
        Destroy(other.gameObject);
        SpawnWeaponPickup(_collisionWeaponTag);
        

    }

    void SpawnWeaponPickup(string tag)
    {

        switch (tag)
        {
            case "DefaultWeapon":
                DestroyWeaponAtHand();
                Destroy(transform.GetChild(0).gameObject);
                var obj = Instantiate(_defaultWeapon);              
                obj.transform.parent = gameObject.transform;
                WeaponAtHand = transform.GetChild(0).gameObject;

                break;

            case "Grenade":
                DestroyWeaponAtHand();
                Destroy(transform.GetChild(0).gameObject);
                var obj2 = Instantiate(_weaponGrenade);                
                obj2.transform.parent = gameObject.transform;
                WeaponAtHand = transform.GetChild(0).gameObject;

                break;

            default:
                break;
        }

    }

    void DestroyWeaponAtHand()
    {
        Object.Destroy(WeaponAtHand);
    }
}
