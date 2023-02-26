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
    [SerializeField]private WaveSpawner waveSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        characterManager = GameObject.FindGameObjectWithTag("CharacterManager").GetComponent<CharacterManager>();
        waveSpawner = GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<WaveSpawner>(); 
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
            characterManager.SetSpawnIndex(1);
            waveSpawner.SetCurSpawnRange(waveSpawner.room2minX, waveSpawner.room2maxX, waveSpawner.room2minY, waveSpawner.room2maxY);
            break;
            case 1:
            doors[1] = true;
            StartCoroutine(OpenDoorInNextRoom(0));
            characterManager.SetSpawnIndex(0);
            waveSpawner.SetCurSpawnRange(waveSpawner.room1minX, waveSpawner.room1maxX, waveSpawner.room1minY, waveSpawner.room1maxY);
            break;
            case 2:
            doors[2] = true;
            StartCoroutine(OpenDoorInNextRoom(3));
            characterManager.SetSpawnIndex(2);
            waveSpawner.SetCurSpawnRange(waveSpawner.room3minX, waveSpawner.room3maxX, waveSpawner.room3minY, waveSpawner.room3maxY);
            break;
            case 3:
            doors[3] = true;
            StartCoroutine(OpenDoorInNextRoom(2));
            characterManager.SetSpawnIndex(1);
            waveSpawner.SetCurSpawnRange(waveSpawner.room2minX, waveSpawner.room2maxX, waveSpawner.room2minY, waveSpawner.room2maxY);
            break;
            case 4:
            doors[4] = true;
            StartCoroutine(OpenDoorInNextRoom(5));
            characterManager.SetSpawnIndex(3);
            waveSpawner.SetCurSpawnRange(waveSpawner.room4minX, waveSpawner.room4maxX, waveSpawner.room4minY, waveSpawner.room4maxY);
            break;
            case 5:
            doors[5] = true;
            StartCoroutine(OpenDoorInNextRoom(4));
            characterManager.SetSpawnIndex(0);
            waveSpawner.SetCurSpawnRange(waveSpawner.room1minX, waveSpawner.room1maxX, waveSpawner.room1minY, waveSpawner.room1maxY);
            break;
            case 6:
            doors[6] = true;
            StartCoroutine(OpenDoorInNextRoom(7));
            characterManager.SetSpawnIndex(3);
            waveSpawner.SetCurSpawnRange(waveSpawner.room4minX, waveSpawner.room4maxX, waveSpawner.room4minY, waveSpawner.room4maxY);
            break;
            case 7:
            doors[7] = true; 
            StartCoroutine(OpenDoorInNextRoom(6));
            characterManager.SetSpawnIndex(2);
            waveSpawner.SetCurSpawnRange(waveSpawner.room1minX, waveSpawner.room1maxX, waveSpawner.room1minY, waveSpawner.room1maxY);
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
