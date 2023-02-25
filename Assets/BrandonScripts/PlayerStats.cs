using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _currHealth;


    void Start()
    {
        _maxHealth = 5;
        _currHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    public void TakeDamagePlayer(int damageAmount){
        Debug.Log("Taking Damage");
        _currHealth -= damageAmount;
    }


}
