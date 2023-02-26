using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LovingWords : MonoBehaviour
{
    [SerializeField]private float _speed;
    [SerializeField]private GameObject _hitParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
            Instantiate(_hitParticle, transform.position, Quaternion.identity);
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, 100f);
            foreach(Collider2D collider in hitColliders){
                if(collider.CompareTag("Enemy")){
                    Debug.Log("Hit an enemy");
                    
                    collider.gameObject.GetComponent<EnemyStats>().TakeDamage(20);
                }
        }
        Destroy(gameObject);
    }
}
