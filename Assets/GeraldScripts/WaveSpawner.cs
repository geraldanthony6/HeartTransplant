using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] enemyArray;
    [SerializeField]private float minX;
    [SerializeField]private float maxX;
    [SerializeField]private float minY;
    [SerializeField]private float maxY;
    [SerializeField]private bool spawnWave = false;
    [SerializeField]private float waveTimer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawnWave && waveTimer <= 0){
            StartCoroutine(SpawnWave(10));
        }

        if(waveTimer > 0){
            waveTimer -= Time.deltaTime;
        }
    }

    IEnumerator SpawnWave(int waveSize){
        spawnWave = true;
        yield return new WaitForSeconds(2f);
        for(int i = 0; i < waveSize; i++){
            Instantiate(enemyArray[Random.Range(0, enemyArray.Length)], new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        spawnWave = false;
        waveTimer = 10;
    }

    public float GetWaveTimer(){
        return waveTimer;
    }
}
