using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool door1Open;
    public bool door2Open;
    [SerializeField]public bool[] doors;
    [SerializeField]private GameObject[] doorsArray;
    [SerializeField]private CharacterManager characterManager;
    
    // Start is called before the first frame update
    void Start()
    {
        characterManager = GameObject.FindGameObjectWithTag("CharacterManager").GetComponent<CharacterManager>();  
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor(int index){
    
        switch(index){
            case 0:
            doors[0] = true;
            StartCoroutine(OpenDoorInNextRoom(1));
            characterManager.curSpawnIndex = 1;
            break;
            case 1:
            doors[1] = true;
            StartCoroutine(OpenDoorInNextRoom(0));
            characterManager.curSpawnIndex = 0;
            break;
            case 2:
            doors[2] = true;
            StartCoroutine(OpenDoorInNextRoom(3));
            characterManager.curSpawnIndex = 2;
            break;
            case 3:
            doors[3] = true;
            StartCoroutine(OpenDoorInNextRoom(2));
            characterManager.curSpawnIndex = 1;
            break;
            case 4:
            doors[4] = true;
            StartCoroutine(OpenDoorInNextRoom(5));
            characterManager.curSpawnIndex = 3;
            break;
            case 5:
            doors[5] = true;
            StartCoroutine(OpenDoorInNextRoom(4));
            characterManager.curSpawnIndex = 0;
            break;
            case 6:
            doors[6] = true;
            StartCoroutine(OpenDoorInNextRoom(7));
            characterManager.curSpawnIndex = 3;
            break;
            case 7:
            doors[7] = true; 
            StartCoroutine(OpenDoorInNextRoom(6));
            characterManager.curSpawnIndex = 2;
            break;

        }
    }

    public IEnumerator OpenDoorInNextRoom(int index){
        Debug.Log("Closing door adjacent");
        doorsArray[index].SetActive(false);

        yield return new WaitForSeconds(5f);

        doorsArray[index].SetActive(true);
        
    }
}
