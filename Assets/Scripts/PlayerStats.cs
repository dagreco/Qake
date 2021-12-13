
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int HP;
    private Slider _slider;

    public void UpdateHealth()
    {
        _slider.value = HP;
        if (HP <= 0)
            Destroy(gameObject);
    }

   

    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
        Physics.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider>());
        HP -= collision.gameObject.GetComponent<Projectile>().Damage;
        Destroy(collision.gameObject);
        UpdateHealth();
        }
    }

    private void Awake()
    {
        _slider = GameObject.Find(gameObject.name + " bar").GetComponent<Slider>();
        _slider.maxValue = HP;
        _slider.value = HP;
    }
}
