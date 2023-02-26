using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public int _maxHealth;
    [SerializeField] public int _currPlayerHealth;
    public Vector2 distance;


    void Start()
    {
        _maxHealth = 5;
        _currPlayerHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    { distance = transform.position;
        if (_currPlayerHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    public void TakeDamagePlayer(int damageAmount)
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
