using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject ActiveWeapon;
    public GameObject ActiveEquipment;
    public GameObject HolsteredWeapon;
    private GameObject HolsteredEquipment;

    private GameObject WeaponsContainer;

    private bool _canPickUp = true;

    private void Awake()
    {
        WeaponsContainer = transform.Find("Weapons").gameObject;
        SetActiveWeapon(transform.Find("Weapons/DefaultWeapon").gameObject); //Sets Default weapon on ActiveWeapon at spawn of player
    }

    public void SetActiveWeapon(GameObject newWeapon)   //Set first active weapon (to be used by the default weapon, when spawning player)
    {
        if (ActiveWeapon == null && HolsteredWeapon == null)
        {
            ActiveWeapon = newWeapon;
            newWeapon.gameObject.transform.SetParent(WeaponsContainer.transform);
        }

        else if(ActiveWeapon != null && HolsteredWeapon == null) //Is called when player has one weapon already. Active becomes holstered and new weapon set to active weapon
        {
            HolsteredWeapon = ActiveWeapon;
            ActiveWeapon = newWeapon;
            HolsteredWeapon.SetActive(false);
            ActiveWeapon.gameObject.transform.SetParent(WeaponsContainer.transform);
            SetPositionOfPickedUpWeapon();
        }
        else if(ActiveWeapon != null && HolsteredWeapon !=null) //Is called when player has two weapons already. Active weapon is dropped and replaced by new weapon
        {
            Drop(ActiveWeapon);
            ActiveWeapon = newWeapon;
            ActiveWeapon.gameObject.transform.SetParent(WeaponsContainer.transform);
            SetPositionOfPickedUpWeapon();
        }
    }

    public void SetActiveEquipment(GameObject newEquipment)
    {
        if (ActiveEquipment == null && HolsteredEquipment == null) ActiveEquipment = newEquipment; 

        else if (ActiveEquipment != null && HolsteredEquipment == null) 
        {
            HolsteredEquipment = ActiveEquipment; HolsteredEquipment.SetActive(false);
            ActiveEquipment = newEquipment;

        }
        else if (ActiveEquipment != null && HolsteredEquipment!= null ) 
        {
            Drop(ActiveEquipment);
            ActiveEquipment = newEquipment;
        }
    }

    public void SwitchWeapons()
    {
        if (ActiveWeapon != null && HolsteredWeapon != null)
        {
            var toBeHolstered = ActiveWeapon;
            ActiveWeapon = HolsteredWeapon; HolsteredWeapon = toBeHolstered;
            ActiveWeapon.SetActive(true); HolsteredWeapon.SetActive(false);
        }
    }

    public void SwitchEquipment()
    {
        if (ActiveEquipment != null && HolsteredEquipment != null)
        {
            var toBeHolstered = ActiveEquipment;
            ActiveEquipment = HolsteredEquipment; HolsteredEquipment = toBeHolstered;
            ActiveEquipment.SetActive(true); HolsteredEquipment.SetActive(false);
        }
    }

    public void Drop(GameObject item)
    {
        item.transform.SetParent(null, true);
        _canPickUp = false;
        Invoke("AllowPickUp", 1f);
    }

    private void AllowPickUp()
    {
        _canPickUp = true;
    }

    public void SetPositionOfPickedUpWeapon()
    {
        ActiveWeapon.gameObject.transform.localPosition += ActiveWeapon.GetComponent<Weapon>().PositionOffset;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Weapon" && _canPickUp)
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            
            Debug.Log("setparent");
            SetActiveWeapon(other.gameObject);
        }    
    }
}
