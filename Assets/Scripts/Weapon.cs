using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage;
    public bool ReadyToShoot = true;
    public float FireRate;

    public abstract void Shoot();
    public abstract void Reload();

    public void Drop()
    {
        gameObject.transform.SetParent(null, true);
    }

    private void Awake()
    {
        
    }
}

