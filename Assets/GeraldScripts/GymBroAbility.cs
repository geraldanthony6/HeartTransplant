using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymBroAbility : MonoBehaviour
{
    [SerializeField]private Transform _pivotPoint;
    [SerializeField]private Transform _fists;
    [SerializeField]private Vector3 _grabOffset = new Vector3(20f, 0);
    [SerializeField]private GameObject curHeldEnemy;
    [SerializeField]private bool isGrabbing = false;
    [SerializeField]private float holdTimer = 0f;
    [SerializeField]private float holdCooldown;
    // Start is called before the first frame update
    void Start()
    {
        curHeldEnemy = null;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _pivotPoint.position; 
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; 
        _pivotPoint.rotation = Quaternion.Euler(0f, 0f, rotation_z);
        //TODO: Add hold timer
        if(Input.GetKey(KeyCode.Mouse0) && holdCooldown <= 0){
            Debug.Log("Tryna grab");
            RaycastHit2D hit = Physics2D.Raycast(_fists.position + _grabOffset, Vector2.right, 50f);

            if(hit.collider != null){
                Debug.Log("Hit Something" + hit.collider.tag);
                if(hit.collider.CompareTag("Enemy")){
                    EnemyStats curEnemyGrabbed = hit.collider.gameObject.GetComponent<EnemyStats>();
                    hit.collider.gameObject.transform.position = _fists.transform.position + _grabOffset;
                    isGrabbing = true;
                    curHeldEnemy = hit.collider.gameObject;
                }
            }
        }    

        if(Input.GetKeyUp(KeyCode.Mouse0)){
            isGrabbing = false;
            holdTimer = 0.5f;
            curHeldEnemy = null;

        }

        if(isGrabbing){
            holdTimer -= Time.deltaTime;
        }

        if(holdTimer <= 0){
            if(curHeldEnemy){
                curHeldEnemy.GetComponent<EnemyStats>().TakeDamage(20);
            }
            
            holdTimer = 0.5f;
            holdCooldown = 2f;
        }

        if(holdCooldown > 0){
            holdCooldown -= Time.deltaTime;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawLine(_fists.transform.position + _grabOffset, _fists.transform.position + new Vector3(10, 0));
    }

    private void OnCollisionEnter2D(Collision2D other) {

    }

    

    
}
