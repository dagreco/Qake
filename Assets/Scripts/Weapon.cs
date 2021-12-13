using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage;
    [SerializeField] protected bool ReadyToShoot = true;
    [SerializeField] protected float FireRate;
    public Vector3 PositionOffset;

    public abstract void Shoot();
    public abstract void Reload();

    public void  SetPosition()
    {
        
        transform.position += PositionOffset;
        Debug.Log(transform.localPosition);
    }

    
}

