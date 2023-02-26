using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] float speed = 0.6f;
    [SerializeField] int damage;

    public Transform player;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime));
        Debug.Log("Player is here: " + player.position);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().TakeDamagePlayer(damage);
        }

    }
}

