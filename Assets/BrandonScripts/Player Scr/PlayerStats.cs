using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public float _maxHealth;
    [SerializeField] public float _currPlayerHealth;
    public float speed = 8;
    public float maxSpeed = 8;
    private Transform enemy;

    public Sprite[] Health;
    public Sprite s1, s2, s3, s4, s5;
    public SpriteRenderer sr;

    public EnemyStatsB EnemyStats { get; private set; }

    void Start()
    {
        Health[1] = s1;
        Health[2] = s2;
        Health[3] = s3;
        Health[4] = s4;
        Health[5] = s5;
        sr = GetComponent<SpriteRenderer>();
        if (_currPlayerHealth > _maxHealth)
        {
            _currPlayerHealth = _maxHealth;
        }
        _maxHealth = 100;
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
        transform.Translate(Vector2.right * speed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector2.up * speed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
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

    public void checkHealth()
    {
        if (_currPlayerHealth >= _maxHealth)
        {
            sr.sprite = Health[1];

        }
        if (_currPlayerHealth <= 75 && _currPlayerHealth >= 50)
        {
            sr.sprite = Health[2];

        }
        if (_currPlayerHealth <= 50 && _currPlayerHealth >= 25)
        {
            sr.sprite = Health[3];

        }
        if (_currPlayerHealth <= 25 && _currPlayerHealth >= 10)
        {
            sr.sprite = Health[4];
        }
         if (_currPlayerHealth <= 10 && _currPlayerHealth >= 1)
        {
            sr.sprite = Health[5];
        }
    }








}
