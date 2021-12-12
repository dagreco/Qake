using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject ActiveWeapon;
    public GameObject ActiveEquipment;
    public GameObject HolsteredWeapon;

    public void SetActiveWeapon(GameObject weapon)
    {
        HolsteredWeapon = ActiveWeapon;
        ActiveWeapon = weapon;
    }

    public void SetActiveEquipment(GameObject equipment)
    {

    }
}
