using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]public float _maxHealth;
    [SerializeField]public float _currHealth;
    [SerializeField]private GameObject heart;

    
    // Start is called before the first frame update
    void Start()
    {
        _currHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage){
        _currHealth -= damage;
        if(_currHealth <= 0){
            Instantiate(heart, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
