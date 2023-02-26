using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]public float speed = 0.6f;
    [SerializeField]public int damage;

    [SerializeField]private Transform player;
    [SerializeField]private EnemyManager enemyManager;
    [SerializeField]private GameObject heart;



    void Start()
    {
        enemyManager = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<EnemyManager>();
        enemyManager.AddEnemyToList(gameObject);
        player = enemyManager.GetCurPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime));

    }

    public void SetPlayer(Transform player){
        this.player = player;
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("DogTrainer"))
        {
            other.gameObject.GetComponent<PlayerStats>().TakeDamagePlayer(damage);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.CompareTag("Player") || other.collider.CompareTag("DogTrainer"))
        {
            other.gameObject.GetComponent<PlayerStats>().TakeDamagePlayer(damage);
            Instantiate(heart, transform.position, Quaternion.identity);
            Destroy(gameObject);
        } 
    }
}
