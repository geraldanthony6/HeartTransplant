using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public float _maxHealth = 100;
    public float _currPlayerHealth;
    public float speed = 8;
    public float maxSpeed = 8;
    private Transform enemy;

    public EnemyStatsB EnemyStats { get; private set; }

    void Start()
    {

        if (_currPlayerHealth > _maxHealth)
        {
            _currPlayerHealth = _maxHealth;
        }
        _currPlayerHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null)
        {
            enemy = GameObject.FindGameObjectWithTag("E").transform;
            EnemyStats = enemy.gameObject.GetComponent<EnemyStatsB>();
            float distance = Vector2.Distance(transform.position, enemy.position);
        }
      
        if (_currPlayerHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    public void TakeDamagePlayer(float damageAmount)
    {
        Debug.Log("Taking Damage");
        _currPlayerHealth -= damageAmount;
        Debug.Log("Player Health is: " + _currPlayerHealth);

    }

    public void Heal()
    {
        _currPlayerHealth++;
        Debug.Log("Player Health is: " + _currPlayerHealth);

    }









}
