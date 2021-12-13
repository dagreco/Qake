using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject ActiveWeapon;
    public GameObject ActiveEquipment;
    private GameObject HolsteredWeapon;
    private GameObject HolsteredEquipment;

    private void Awake()
    {
        SetActiveWeapon(transform.Find("Weapons/DefaultWeapon").gameObject);
    }

    public void SetActiveWeapon(GameObject newWeapon)
    {
        if(ActiveWeapon == null && HolsteredWeapon == null) ActiveWeapon = newWeapon; //Set first active weapon (to be used by the default weapon, when spawning player)

        else if(ActiveWeapon != null && HolsteredWeapon == null) //Is called when player has one weapon already. Active becomes holstered and new weapon set to active weapon
        {
            HolsteredWeapon = ActiveWeapon; HolsteredWeapon.SetActive(false);
            ActiveWeapon = newWeapon;
        }
        else if(ActiveWeapon != null && HolsteredWeapon !=null) //Is called when player has two weapons already. Active weapon is dropped and replaced by new weapon
        {
            Drop(ActiveWeapon);
            ActiveWeapon = newWeapon;
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
        else if (ActiveEquipment != null && HolsteredEquipment!= null) 
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
    }
}
