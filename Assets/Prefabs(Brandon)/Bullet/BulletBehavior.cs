using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float speed;
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("E"))
        {
            Debug.Log("Hit an enemy");
            other.gameObject.GetComponent<EnemyStatsB>().TakeDamageEnemy(damage);
            Destroy(gameObject);
        }

    }
}
