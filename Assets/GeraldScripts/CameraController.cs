using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private DoorManager doorManager;
    [SerializeField]private Transform level1Pos;
    [SerializeField]private Transform level2Pos;
    [SerializeField]private Transform level3Pos;
    [SerializeField]private Transform level4Pos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(doorManager.doors[0]){
            transform.position = Vector3.Lerp(transform.position,level2Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level2Pos.position) <= 30){
                doorManager.doors[0] = false;
            }
        } 

        if(doorManager.doors[1]){
            transform.position = Vector3.Lerp(transform.position,level1Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level1Pos.position) <= 10){
                doorManager.doors[1] = false;
            }
        }

        if(doorManager.doors[2]){
            transform.position = Vector3.Lerp(transform.position,level3Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level3Pos.position) <= 10){
                doorManager.doors[2] = false;
            }
        }

        if(doorManager.doors[3]){
            transform.position = Vector3.Lerp(transform.position,level2Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level2Pos.position) <= 10){
                doorManager.doors[3] = false;
            }
        }

        if(doorManager.doors[4]){
            transform.position = Vector3.Lerp(transform.position,level4Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level4Pos.position) <= 10){
                doorManager.doors[4] = false;
            }
        }

        if(doorManager.doors[5]){
            transform.position = Vector3.Lerp(transform.position,level1Pos.position, 1 * Time.deltaTime);
            if(Vector3.Distance(transform.position, level1Pos.position) <= 10){
                doorManager.doors[5] = false;
            }
        }

        if(doorManager.doors[6]){
            transform.position = Vector3.Lerp(transform.position, level4Pos.position, 1 * Time.deltaTime); 
            if(Vector3.Distance(transform.position, level4Pos.position) <= 10){
                doorManager.doors[6] = false;
            }
        }

        if(doorManager.doors[7]){
            transform.position = Vector3.Lerp(transform.position, level3Pos.position, 1 * Time.deltaTime); 
            if(Vector3.Distance(transform.position, level3Pos.position) <= 10){
                doorManager.doors[7] = false;
            }
        }
    }
}
