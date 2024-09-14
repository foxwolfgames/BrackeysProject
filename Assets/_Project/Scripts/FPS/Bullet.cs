using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage;
    [SerializeField] private float lifetime;
    [SerializeField] public float maxLifetime;

    void Update()
    {
        lifetime += Time.deltaTime;
        if (lifetime >= maxLifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        CreateBulletImpactEffect(collision);
        if (collision.gameObject.CompareTag("Target"))
        {
            print("hit " + collision.gameObject.name);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall")) {
            print("hit wall");
            Destroy(gameObject);
        }

        /*
        if (collision.gameObject.CompareTag("Enemy")) {
            print("hit enemy");
            collision.gameObject.GetComponent<BasicEnemy>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        */
    }

    private void CreateBulletImpactEffect(Collision collision)
    {
        ContactPoint contactPoint = collision.contacts[0];
        GameObject impactEffect = Instantiate(
            GlobalReferences.Instance.bulletImpactEffectPrefab,
            contactPoint.point,
            Quaternion.LookRotation(contactPoint.normal)
            );
        impactEffect.transform.SetParent(collision.gameObject.transform);
    }
}