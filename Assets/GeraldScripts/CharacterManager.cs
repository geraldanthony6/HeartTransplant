using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]private GameObject activePlayer;
    [SerializeField]private GameObject[] characterList;
    [SerializeField]private Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        ChangePlayer(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && (activePlayer != characterList[0])){
            ChangePlayer(0);
        } 

        if(Input.GetKeyDown(KeyCode.Alpha2) && (activePlayer != characterList[1])){
            ChangePlayer(1);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3) && (activePlayer != characterList[2])){
            ChangePlayer(2);
        }
    }

    void ChangePlayer(int index){
        switch(index){
            case 0:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos.position, Quaternion.identity);
            break;
            case 1:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos.position, Quaternion.identity);
            break;
            case 2:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos.position, Quaternion.identity);
            break;
        }
    }
}
