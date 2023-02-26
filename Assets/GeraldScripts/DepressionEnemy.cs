using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepressionEnemy : MonoBehaviour
{
    [SerializeField]private Transform player;
    [SerializeField]private PlayerStats playerStats;
    [SerializeField]private EnemyManager enemyManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyManager = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<EnemyManager>();
        player = enemyManager.GetCurPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if(distance <= 3){
            Debug.Log("Drain Player Health");
        }
    }
}
