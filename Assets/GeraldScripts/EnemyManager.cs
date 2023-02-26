using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]private GameObject curPlayer;
    [SerializeField]private List<GameObject> curEnemyList;
    // Start is called before the first frame update
    void Start()
    {
        if(!curPlayer){
            if(GameObject.FindGameObjectWithTag("Player")){
                curPlayer = GameObject.FindGameObjectWithTag("Player");
            } else
            {
                curPlayer = GameObject.FindGameObjectWithTag("DogTrainer");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurPlayer(GameObject player){
        curPlayer = player;
        foreach (GameObject enemy in curEnemyList)
        {
            enemy.GetComponent<EnemyMovement>().SetPlayer(curPlayer.transform);
        }
    }

    public Transform GetCurPlayer(){
        return curPlayer.transform;
    }

    public void AddEnemyToList(GameObject enemy){
        curEnemyList.Add(enemy);
    }
}
