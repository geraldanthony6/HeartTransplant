using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymBroAbility : MonoBehaviour
{
    [SerializeField]private Vector3 _grabOffset = new Vector3(3f, 0);
    [SerializeField]private bool isGrabbing = false;
    [SerializeField]private float holdTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Add hold timer
        if(Input.GetKey(KeyCode.Q)){
            Debug.Log("Tryna grab");
            RaycastHit2D hit = Physics2D.Raycast(transform.position + _grabOffset, Vector2.right, 10f);

            if(hit.collider != null){
                Debug.Log("Hit Something" + hit.collider.tag);
                if(hit.collider.CompareTag("Enemy")){
                    EnemyStats curEnemyGrabbed = hit.collider.gameObject.GetComponent<EnemyStats>();
                    hit.collider.gameObject.transform.position = transform.position + _grabOffset;
                    isGrabbing = true;
                }
            }
        }    

        if(Input.GetKeyUp(KeyCode.Q)){
            isGrabbing = false;
            holdTimer = 10;
        }

        if(isGrabbing){
            holdTimer -= Time.deltaTime * 100;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawLine(transform.position + _grabOffset, transform.position + new Vector3(10, 0));
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(isGrabbing && other.gameObject.CompareTag("Enemy")){
            if(holdTimer % 2 == 0){
                other.gameObject.GetComponent<EnemyStats>().TakeDamage(20);
            }
        }
    }

    
}
