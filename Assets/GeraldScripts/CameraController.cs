using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private DoorManager doorManager;
    [SerializeField]private Transform level2Pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(doorManager.door1Open){
            transform.position = Vector3.Lerp(transform.position,level2Pos.position, 1 * Time.deltaTime);
        }
    }
}
