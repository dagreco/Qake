using UnityEngine;

public class ProjectileDefault : MonoBehaviour
{
    private Rigidbody _projectileRB;
    public float FireForce = 10;
    // Start is called before the first frame update
    void Start()
    {
       _projectileRB = GetComponent<Rigidbody>();
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        _projectileRB.AddRelativeForce(Vector3.forward * FireForce, ForceMode.VelocityChange);
    }
}
