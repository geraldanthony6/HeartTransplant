using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatsB : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currHealth;
    [SerializeField] GameObject heart;
    private int eCount;

    // Start is called before the first frame update
    void Start()
    {
        _maxHealth = 5f;
        _currHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currHealth <= 0)
        {
            Instantiate(heart, transform.position, transform.rotation);

            Destroy(gameObject);
            // if (eCount % 10 == 0)
            // {
            //     Instantiate(heart, transform.position, transform.rotation);
            // 
        }
    }

    public void TakeDamageEnemy(int damage)
    {
        _currHealth -= damage;
        Debug.Log("Enemy Health is: " + _currHealth);

    }
}
