using UnityEngine;

[CreateAssetMenu(fileName = "New Ranged Weapon", menuName = "Items/Weapons/Ranged")]
public class RangedAttributes : WeaponsAttributes
{
    public int StartingAmmo;
    public int MagazineSize;
    [HideInInspector] public int AmmoInMagazine;
    [HideInInspector] public GameObject ProjectileSpawnpoint;
    public Vector3 PositionOffset;

    private void Awake()
    {
        ProjectileSpawnpoint = Prefab.transform.GetChild(0).gameObject;
        AmmoInMagazine = MagazineSize;
    }
}
