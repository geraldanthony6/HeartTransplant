using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]private float _maxHealth;
    [SerializeField]private float _currHealth;
    // Start is called before the first frame update
    void Start()
    {
        _maxHealth = 100f;
        _currHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage){
        _currHealth -= damage;
        if(_currHealth <= 0){
            Destroy(gameObject);
        }
    }
}