using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]private GameObject activePlayer;
    [SerializeField]private GameObject[] characterList;
    [SerializeField]public Transform[] spawnPos;
    [SerializeField]private WaveSpawner waveSpawner;
    [SerializeField]private EnemyManager enemyManager;
    [SerializeField]private Animator transitionAnimation;
    [SerializeField]private GameObject transitionScreen;
    private bool currentlySwitching = false;
    public int curSpawnIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TransitionAnim());
        ChangePlayer(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && (activePlayer != characterList[0]) && !currentlySwitching && (waveSpawner.GetWaveTimer() > 0)){
            StartCoroutine(TransitionAnim());
            ChangePlayer(0);
        } 

        if(Input.GetKeyDown(KeyCode.Alpha2) && (activePlayer != characterList[1]) && !currentlySwitching && (waveSpawner.GetWaveTimer() > 0)){
            StartCoroutine(TransitionAnim());
            ChangePlayer(1);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3) && (activePlayer != characterList[2]) && !currentlySwitching && (waveSpawner.GetWaveTimer() > 0)){
            StartCoroutine(TransitionAnim());
            ChangePlayer(2);
        }
    }

    void ChangePlayer(int index){
  
        switch(index){
            case 0:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos[curSpawnIndex].position, Quaternion.identity);
                enemyManager.SetCurPlayer(activePlayer);
            break;
            case 1:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos[curSpawnIndex].position, Quaternion.identity);
                enemyManager.SetCurPlayer(activePlayer);
            break;
            case 2:
                Destroy(activePlayer);
                activePlayer = Instantiate(characterList[index], spawnPos[curSpawnIndex].position, Quaternion.identity);
                enemyManager.SetCurPlayer(activePlayer);
            break;
        }
       
    }

    IEnumerator TransitionAnim(){
        transitionScreen.SetActive(true);
        currentlySwitching = true;

        yield return new WaitForSeconds(2f);

        currentlySwitching = false;
        transitionScreen.SetActive(false);
    }
}
