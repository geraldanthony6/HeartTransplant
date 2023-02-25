using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField]private DogTrainer dogTrainer;

    private void Awake() {
        dogTrainer = GameObject.FindGameObjectWithTag("DogTrainer").GetComponent<DogTrainer>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
            other.gameObject.GetComponent<EnemyStats>().TakeDamage(20); 
            
            if(!dogTrainer.getDogOneAvailable()){
                dogTrainer.SetDog1Target(null);
            } 

            if(!dogTrainer.getDogTwoAvailable()){
                dogTrainer.SetDog2Target(null);
            }
        }

        if(other.CompareTag("DogPos")){
            transform.parent = dogTrainer.gameObject.transform;
        }
    }
}
