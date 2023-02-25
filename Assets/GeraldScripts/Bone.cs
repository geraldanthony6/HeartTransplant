using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : MonoBehaviour
{
    [SerializeField]private DogTrainer dogTrainer;
    // Start is called before the first frame update
    void Start()
    {
        dogTrainer = GameObject.FindGameObjectWithTag("DogTrainer").GetComponent<DogTrainer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 50 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
            Debug.Log("Hit Enemy");
            if(dogTrainer.getDogOneAvailable())
            {
                dogTrainer.SetDog1Target(other.gameObject);
                dogTrainer.SetDogOneAvailable(false);
            } else if(dogTrainer.getDogTwoAvailable()){
                dogTrainer.SetDog2Target(other.gameObject);
                dogTrainer.SetDogTwoAvailable(false);
            } else if(!dogTrainer.getDogOneAvailable() && !dogTrainer.getDogTwoAvailable()){
                Debug.Log("All dogs busy");
            }
        }
    }
}
