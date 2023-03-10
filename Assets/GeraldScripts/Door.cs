using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]private DoorManager doorManager;
    [SerializeField]private CharacterManager characterManager;
    [SerializeField]private int doorIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") || other.CompareTag("DogTrainer")){
            Debug.Log("Hit door");
            doorManager.OpenDoor(doorIndex);
        }
    }
}
