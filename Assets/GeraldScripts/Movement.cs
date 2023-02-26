using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private float moveSpeed;
    private bool movedThroughDoor1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"));

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Door1")){
            movedThroughDoor1 = true;
            Debug.Log("Go to next room");
        }
    }

    public bool GetMovedThroughtDoor1(){
        return movedThroughDoor1;
    }
}
